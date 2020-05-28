using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;
using Core.Interfaces;
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
    }
}