using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;
using Core.Specification;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T:BaseEntity
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetExaminationCenterWithUsers(ISpecification<T> spec);
        
        Task<T> GetExaminationCenterWithUser(ISpecification<T> spec);
        Task<IReadOnlyList<T>> ListAllAsync(ISpecification<T> spec);

    }
}