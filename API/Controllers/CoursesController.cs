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
        private readonly IGenericRepository<Address> _addressRepo;
        private readonly IGenericRepository<ExaminationCenter> _centerRepo;

        private readonly ICourseRepository _repo;
        public CoursesController(ICourseRepository repo, IGenericRepository<Address> addressRepo,
                                IGenericRepository<ExaminationCenter> centerRepo)
        {
            this._centerRepo = centerRepo;
            this._addressRepo = addressRepo;
            this._repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Course>>> GetCourses()
        {
            var courses = await _repo.GetCourses();
            return Ok(courses);
        }

        [HttpGet]
        [Route("address")]
        public async Task<ActionResult<List<Address>>> GetAddress()
        {
            var address = await _addressRepo.GetAllAsync();
            return Ok(address);
        }

        [HttpGet]
        [Route("centers")]
        public async Task<ActionResult<List<Address>>> GetExaminationCenters()
        {
            var centers = await _centerRepo.GetAllAsync();
            return Ok(centers);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Course>> GetCourseById(int id)
        {
            return Ok(await _repo.GetCourseById(id));
        }



    }
}