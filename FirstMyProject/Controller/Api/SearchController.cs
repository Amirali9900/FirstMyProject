using FirstMyProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstMyProject.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ICakeRepository _cakeRepository;

        public SearchController(ICakeRepository cakeRepository)
        {
            _cakeRepository = cakeRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var allCakes = _cakeRepository.AllCake;
            return Ok(allCakes);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (!_cakeRepository.AllCake.Any(p => p.CakeId == id))
                return NotFound();
            return Ok(_cakeRepository.AllCake.Where(p => p.CakeId == id));
        }

        [HttpPost]
        public IActionResult SearchCakes([FromBody] string searchQuery)
        {
            IEnumerable<Cake> cakes = new List<Cake>();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                cakes = _cakeRepository.SearchCakes(searchQuery);
            }

            return new JsonResult(cakes);
        }
    }
}
