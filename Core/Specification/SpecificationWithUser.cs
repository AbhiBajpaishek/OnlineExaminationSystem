using System.Linq.Expressions;
using Core.Entity;

namespace Core.Specification
{
    public class SpecificationWithUser<T> : BaseSpecification<ExaminationCenter>
    {
        public SpecificationWithUser(int Id): base(u=> u.Id==Id)
        {
            AddInclude(u=> u.User);
            AddInclude(u=>u.Address);
        }
        public SpecificationWithUser() : base()
        {
            AddInclude(u=> u.User);
            AddInclude(u=>u.Address);
        }
    }
}