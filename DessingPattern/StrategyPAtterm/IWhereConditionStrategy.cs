using DessingPattern.Models;
using DessingPattern.UnitOfWorkPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DessingPattern.StrategyPAtterm
{
    public interface IWhereConditionStrategy<TEntity>
    {
        public IEnumerable<TEntity> WhereCondition(cursosonlineContext context, Expression<Func<TEntity, bool>> whereCondition, IUnitOfWorkGenericcs unitOfWorkGenericcs);
    }
}
