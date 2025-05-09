using Microsoft.AspNetCore.Mvc;
using FirstMyProject.Models;

namespace FirstMyProject.Controller
{
    public class CakeController : ControllerContext
    {
        private readonly ICakeRepository _cakeRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CakeController(ICakeRepository cakeRepository,ICategoryRepository categoryRepository)
        {
            _cakeRepository = cakeRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            return View();
        }
    }
}
