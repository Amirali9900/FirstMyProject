using Microsoft.AspNetCore.Mvc;
using FirstMyProject.Models;
using FirstMyProject.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
            CakeListVIewModel cakeListVIewModel = new CakeListVIewModel(_cakeRepository.AllCake , "cake");
            return View(cakeListVIewModel);

        }
    }
}
