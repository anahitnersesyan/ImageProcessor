using System.Linq.Expressions;

namespace ImageProcessor.DataAccessLayer.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        void Remove(T entity);
        void RemoveByRange(IEnumerable<T> entities);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> filter = null);
    }
}
