using ImageProcessor.DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ImageProcessor.DataAccessLayer.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Task<T> AddAsync(T entity)
        {
            //TODO
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<T> entities)
        {
            //TODO
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            //TODO
            throw new NotImplementedException();
        }

        public void RemoveByRange(IEnumerable<T> entities)
        {
            //TODO
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //TODO
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            //TODO
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            //TODO
            throw new NotImplementedException();
        }
        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            //TODO
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> filter = null)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
