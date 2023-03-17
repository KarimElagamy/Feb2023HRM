using System.Linq.Expressions;

namespace ApplicationCore.Contracts.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        // IEnumerable<T> GetAll();
        Task<T> GetByIdAsync(int id);
        Task<bool> GetExistsAsync(Expression<Func<T, bool>>? filter = null);
        Task<int> AddtAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(int id);

    }
}