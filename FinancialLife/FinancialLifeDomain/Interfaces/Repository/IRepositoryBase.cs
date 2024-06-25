namespace FinancialLifeDomain.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task<TEntity> Flush<TEntity>(TEntity entity) where TEntity : class;
        Task<TEntity> Update(TEntity entity);
        Task Delete(int id);
    }
}
