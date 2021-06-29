using DessingPattern.Models;
using DessingPattern.UnitOfWorkPattern;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DessingPattern.RepositoryPattern
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private cursosonlineContext _context;
        private DbSet<TEntity> _dbSet;

        public GenericRepository(cursosonlineContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public async Task<IEnumerable<TEntity>> GetAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }
        public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> whereCondition = null, 
                                            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                                            
                                            string includeProperties = "")
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            if(whereCondition != null)
            {
                query = query.Where(whereCondition);
            }

            foreach (var item in includeProperties
                                .Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(item);
            }

            if(orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }

        }

        public Task<bool> CreateAsync(TEntity data)
        {
            throw new NotImplementedException();
        }




    }
}
