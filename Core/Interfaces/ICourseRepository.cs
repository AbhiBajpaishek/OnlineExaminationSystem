using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;

namespace Core.Interfaces
{
    public interface ICourseRepository
    {
        Task<IReadOnlyList<Course>> GetCourses();
        Task<Course> GetCourseById(int id);

    }
}