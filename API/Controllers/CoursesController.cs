using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Data;
using Core.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;

namespace API.Controllers
{
    [ApiController]
    [Route("API/[Controller]")]
    public class CoursesController : ControllerBase
    {
        
        private readonly ICourseRepository _repo;
        public CoursesController(ICourseRepository repo)
        {
            this._repo = repo;
        }
      

        [HttpGet]
        public async Task<ActionResult<List<Course>>> GetCourses()
        {
            var courses=await _repo.GetCourses();
            return Ok(courses);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Course>> GetCourseById(int id)
        {
            return Ok( await _repo.GetCourseById(id));
        }

    }
}