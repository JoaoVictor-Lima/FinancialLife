namespace FinancialLifeDomain.Core.AbstractFactory
{
    public abstract class AbstractFactory<TEntity, TDto> : IFactory<TEntity, TDto>
        where TEntity : class 
        where TDto : class
    {
        public abstract TEntity Create(TDto dto);
    }
}
