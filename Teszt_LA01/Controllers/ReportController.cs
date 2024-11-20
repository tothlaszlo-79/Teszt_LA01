using Microsoft.AspNetCore.Mvc;
using Teszt_LA01.Data;
using Teszt_LA01.Models;

namespace Teszt_LA01.Controllers
{
    public class ReportController : Controller
    {
        private readonly TesztContext _context;

        public ReportController(TesztContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var adatok = from p in _context.Products
                         join c in _context.Categories on p.CategoryId equals c.CategoryId
                         select new ReportClass{ 
                             ProductId = p.ProductId,
                             ProductName =   p.Name,
                             Description =  p.Description, 
                             Price =  p.Price, 
                             CategoryName = c.Name 
                         };

            return View(adatok.ToList());
        }
    }
}
