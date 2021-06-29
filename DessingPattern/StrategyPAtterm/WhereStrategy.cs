using DessingPattern.Models;
using DessingPattern.RepositoryPattern;
using DessingPattern.UnitOfWorkPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DessingPattern.StrategyPAtterm
{
    public class WhereStrategy<TEntity> : IWhereConditionStrategy<TEntity> where TEntity : class
    {
        public IEnumerable<TEntity> WhereCondition(cursosonlineContext _context, Expression<Func<TEntity, bool>> whereCondition, IUnitOfWorkGenericcs unitOfWorkGenericcs)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            query = query.Where(whereCondition);
            return query;
        }
    }
}
