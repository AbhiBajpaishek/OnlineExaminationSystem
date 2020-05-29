using System.Linq;
using Core.Entity;
using Core.Specification;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class SpecificationEvaluator<T> where T:BaseEntity
    {
        public static IQueryable<T> GetQuery(IQueryable<T> query,ISpecification<T> spec)
        {   
            var q=query;
            if(spec.Criteria!=null)
            {
                q=q.Where(spec.Criteria);
            }

            q=spec.Includes.Aggregate(q,(current,includes)=> current.Include(includes));
            return q;
        }
    }
}