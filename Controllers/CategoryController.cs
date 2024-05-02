using Microsoft.AspNetCore.Mvc;

namespace AmsT4_Carousel.Controllers
{
    public class CategoryController : Controller
    {
    
        private ApplicationDataContext _applicationDataContext;

        public CategoryController(ApplicationDataContext applicationDataContext)
        { _applicationDataContext = applicationDataContext; }

        public IActionResult CategoryList()
        {
            var categories = _applicationDataContext.Category.ToList();

            return View(categories);
        }
    }
}
