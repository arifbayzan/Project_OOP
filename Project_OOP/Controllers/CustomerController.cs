using Microsoft.AspNetCore.Mvc;
using Project_OOP.Entity;
using Project_OOP.ProjectContext;

namespace Project_OOP.Controllers
{
    public class CustomerController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Customers.ToList();
            return View();
        }

        [HttpGet]

        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]

        public IActionResult AddCustomer(Customer p)
        {
            context.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCustomer(int id)
        {
            var value = context.Customers.Where(x => x.ID == id).FirstOrDefault();
            context.Remove(value);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var value = context.Customers.Where(x => x.ID == id).FirstOrDefault();
            return View(value);
        }

        [HttpPost]

        public IActionResult UpdateCustomer(Customer p)
        {
            var value = context.Customers.Where(x => x.ID == p.ID).FirstOrDefault();
            value.City = p.City;
            value.Name = p.Name;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
