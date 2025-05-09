using Microsoft.AspNetCore.Mvc;
using FirstMyProject.Models;
using FirstMyProject.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Http.HttpResults;

namespace FirstMyProject.Controllers
{
    public class CakeController : Controller
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
            CakeListVIewModel cakeListVIewModel = new CakeListVIewModel(_cakeRepository.AllCake , "All Cake");
            return View(cakeListVIewModel);
        }
        public IActionResult Details(int id)
        {
            var cake = _cakeRepository.GetCakeById(id);
            if (cake == null)
                return NotFound();
            return View(cake);
        }
    }
}
