using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DessingPattern.RepositoryPattern
{
    public interface IGenericRepository<TEntiy> where TEntiy : class
    {
        Task<IEnumerable<TEntiy>> GetAsync();
        Task<IEnumerable<TEntiy>> GetAsync(Expression<Func<TEntiy, bool>> whereCondition = null,
                    Func<IQueryable<TEntiy>, IOrderedQueryable<TEntiy>> orderBy = null,
                    string includeProperties = "");
        Task<bool> CreateAsync(TEntiy data);
    }
}
