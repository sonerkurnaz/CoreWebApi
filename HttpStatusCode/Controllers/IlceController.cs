using HttpStatusCode.Infrastructure.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HttpStatusCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IlceController : ControllerBase
    {
        private readonly IilceDAL ilceDAL;

        public IlceController(IilceDAL ilceDAL)
        {
            this.ilceDAL = ilceDAL;
        }
        [HttpGet]
        public IActionResult GetIlceler(int? sehirId)
        {
            var sonuc = ilceDAL.FindAll(p => p.SehirId == sehirId);
            if (sonuc != null)
            {
                return Ok(sonuc);
            }
            else
            {
                return NotFound();
            }


        }
    }
}
