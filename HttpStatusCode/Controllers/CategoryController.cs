using HttpStatusCode.Infrastructure.Repository.Abstract;
using HttpStatusCode.Models.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HttpStatusCode.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryDAL categoryDAL;

        public CategoryController(ICategoryDAL categoryDAL)
        {
            this.categoryDAL = categoryDAL;
        }
        [HttpGet]
        public IActionResult GetCAtegories()
        {
            var result = categoryDAL.FindAll();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var category = categoryDAL.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(category);
            }
        }
        [HttpPost]
        public IActionResult CreateCategory([FromBody] Category input)
        {
            if (input == null)
            {
                return BadRequest();
            }
            var sonuc = categoryDAL.CheckName(input.Name);

            if (sonuc == true)
            {
                ModelState.AddModelError("", $"")
                return StatusCode(406);
            }
            categoryDAL.Add(input);
            return Ok(input);
        }
    }
}
