using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class CourseRepository : ICourseRepository
    {
        private readonly MyDbContext _context;

        public CourseRepository(MyDbContext context)
        {
            this._context = context;
        }
        public async Task<Course> GetCourseById(int id)
        {
            
            return await _context.Courses.FirstOrDefaultAsync(p=> p.Id==id);
        }

        public async Task<IReadOnlyList<Course>> GetCourses()
        {
            return await _context.Courses.ToListAsync();
        }
    }
}