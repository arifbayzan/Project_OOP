using Microsoft.AspNetCore.Mvc;
using Project_OOP.ProjectContext;

namespace Project_OOP.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();

        public IActionResult Index()
        {
            var values = context.Products.ToList();
            return View(values);
        }
    }
}
