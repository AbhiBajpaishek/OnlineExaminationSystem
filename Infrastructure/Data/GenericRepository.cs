using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entity;
using Core.Interfaces;
using Core.Specification;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T: BaseEntity
    {
        private readonly MyDbContext _context;
        public GenericRepository(MyDbContext context)
        {
            this._context = context;
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            var data = await _context.Set<T>()
                .ToListAsync();
            return data;
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<T> GetExaminationCenterWithUser(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<T>> GetExaminationCenterWithUsers(ISpecification<T> spec)
        {
            var query=ApplySpecification(spec);
            return await query.ToListAsync();
        }

        public Task<IReadOnlyList<T>> ListAllAsync(ISpecification<T> spec)
        {
            throw new System.NotImplementedException();
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(),
                                                    spec);
        }
    }
}