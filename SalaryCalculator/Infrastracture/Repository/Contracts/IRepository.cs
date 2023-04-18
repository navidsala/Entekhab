namespace SalaryCalculator.Infrastracture.Repository.Contracts
{
    public interface IRepository<TEntity>where TEntity : class, new()
    {
        Task<List<T>> SelectAll<T>() where T : class;
        Task<T> SelectById<T>(int id) where T : class;
        Task<List<T>> SelectByUserId<T>(int UseId) where T : class;
        Task CreateAsync<T>(T entity) where T : class;
        Task UpdateAsync<T>(T entity) where T : class;
        Task DeleteAsync<T>(T entity) where T : class;
    }
}
