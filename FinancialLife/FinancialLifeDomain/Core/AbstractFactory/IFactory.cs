namespace FinancialLifeDomain.Core.AbstractFactory
{
    public interface IFactory<TEntity, TDto>
        where TEntity : class
        where TDto : class
    {
        TEntity Create(TDto dto);
    }
}