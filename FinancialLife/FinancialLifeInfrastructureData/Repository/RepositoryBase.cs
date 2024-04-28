using FinancialLifeDomain.Core.AggregateRoot;
using FinancialLifeDomain.Interfaces.Repository;
using FinancialLifeInfrastructureData.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Reflection;

namespace FinancialLifeInfrastructureData.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {

        protected FinancialLifeDbContext _context;

        public RepositoryBase(FinancialLifeDbContext context)
        {
            _context = context;
        }
        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }
        private async Task<TEntity> Create<TEntity>(TEntity entity) where TEntity : class
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<TEntity> Flush<TEntity>(TEntity entity) where TEntity : class
        {
            if (!(entity is IAggregateRoot || entity is IAggregate))
            {
                throw new ArgumentException("Entity must implement either IAggregateRoot or IAggregate.");
            }

            if (typeof(IAggregateRoot).IsAssignableFrom(typeof(TEntity)))
            {
                var (entityWithoutAggregates, aggregates) = DisconnectAggregateProperties(entity);
                var createdEntity = await Create(entityWithoutAggregates);
                var rootId = GetEntityId(createdEntity);

                foreach (var aggregate in aggregates)
                {
                    if (aggregate is IEnumerable enumerable)
                    {
                        foreach (var item in enumerable)
                        {
                            SetForeignKey(item, createdEntity.GetType(), rootId);
                            await ProcessAggregate(item);
                        }
                    }
                    else
                    {
                        SetForeignKey(aggregate, createdEntity.GetType(), rootId);
                        await ProcessAggregate(aggregate);
                    }
                }
            }
            else
            {
                await Create(entity);
            }

            return entity;
        }

        private object GetEntityId<TEntity>(TEntity entity) where TEntity : class
        {
            var type = entity.GetType();
            PropertyInfo idProp = null;

            idProp = type.GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            if (idProp != null && idProp.CanRead)
            {
                var idValue = idProp.GetValue(entity);
                if (idValue != null && Convert.ToInt32(idValue) > 0)
                {
                    return idValue;
                }
            }

            type = type.BaseType;
            while (type != null)
            {
                idProp = type.GetProperty("Id", BindingFlags.Public | BindingFlags.Instance);
                if (idProp != null && idProp.CanRead)
                {
                    var idValue = idProp.GetValue(entity);
                    if (idValue != null && Convert.ToInt32(idValue) > 0)
                    {
                        return idValue;
                    }
                }
                type = type.BaseType;
            }

            throw new InvalidOperationException("No valid 'Id' property found on this entity or its base types.");
        }

        private (TEntity, List<object>) DisconnectAggregateProperties<TEntity>(TEntity entity) where TEntity : class
        {
            var aggregates = new List<object>();

            var type = entity.GetType();
            var properties = new List<PropertyInfo>();

            while (type != null)
            {
                var newProperties = type.GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => (typeof(IEnumerable).IsAssignableFrom(p.PropertyType) &&
                                 p.PropertyType != typeof(string) &&
                                 p.PropertyType.GetGenericArguments().Any(arg => typeof(IAggregateRoot).IsAssignableFrom(arg) || typeof(IAggregate).IsAssignableFrom(arg)))
                             || typeof(IAggregateRoot).IsAssignableFrom(p.PropertyType)
                             || typeof(IAggregate).IsAssignableFrom(p.PropertyType))
                    .ToList();

                foreach (var newProp in newProperties)
                {
                    var existingProp = properties.FirstOrDefault(p => p.Name == newProp.Name);
                    if (existingProp == null || !existingProp.CanWrite)
                    {
                        properties.Remove(properties.FirstOrDefault(p => p.Name == newProp.Name));
                        properties.Add(newProp);
                    }
                }

                type = type.BaseType;
            }

            foreach (var property in properties)
            {
                var value = property.GetValue(entity);

                if (value != null)
                {
                    aggregates.Add(value);
                    ResetAggregateProperty(entity, property);
                }
            }

            return (entity, aggregates);
        }

        private void ResetAggregateProperty<TEntity>(TEntity entity, PropertyInfo property)
        {
            if (property.PropertyType.GetInterface(nameof(IEnumerable)) != null &&
                property.PropertyType != typeof(string))
            {
                var elementType = property.PropertyType.GetGenericArguments()[0];
                var newCollection = typeof(List<>).MakeGenericType(elementType).GetConstructor(Type.EmptyTypes).Invoke(null);
                var setter = property.GetSetMethod(true); 
                if (setter != null)
                {
                    setter.Invoke(entity, new object[] { newCollection });
                }
            }
            else
            {
                var setMethod = property.GetSetMethod(true);
                if (setMethod != null)
                {
                    object newValue = property.PropertyType.IsValueType ? Activator.CreateInstance(property.PropertyType) : null;
                    setMethod.Invoke(entity, new object[] { newValue });
                }
            }
        }

        private async Task ProcessAggregate(object aggregate)
        {
            if (aggregate is IEnumerable aggregates && !(aggregate is string))
            {
                foreach (var item in aggregates)
                {
                    if (item is IAggregateRoot || item is IAggregate)
                    {
                        await ProcessAggregate(item);
                    }
                }
            }
            else if (aggregate is IAggregateRoot aggregateRoot)
            {
                await Flush(aggregateRoot);
            }
            else if (aggregate is IAggregate simpleAggregate)
            {
                await Create(simpleAggregate as dynamic);
            }
        }

        private void SetForeignKey(object aggregate, Type rootType, object rootId)
        {
            PropertyInfo propInfo = FindForeignKeyProperty(aggregate.GetType(), rootType);
            if (propInfo != null)
            {
                propInfo.SetValue(aggregate, rootId);
            }
            else
            {
                throw new InvalidOperationException($"No foreign key property found for '{rootType.Name}' or its base in {aggregate.GetType().Name}");
            }
        }
        private PropertyInfo FindForeignKeyProperty(Type aggregateType, Type rootType)
        {
            PropertyInfo propInfo = null;
            Type currentType = rootType;
            while (currentType != null && propInfo == null)
            {
                string fkPropertyName = $"Id{currentType.Name}";
                propInfo = aggregateType.GetProperty(fkPropertyName);
                currentType = currentType.BaseType;
            }
            return propInfo;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }


        public async Task Delete(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
