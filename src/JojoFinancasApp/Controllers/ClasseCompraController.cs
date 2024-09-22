using JojoFinancasApp.Data;
using Microsoft.AspNetCore.Mvc;
using JojoFinancasApp.Models;

namespace JojoFinancasApp.Controllers
{
    public class ClasseCompraController : Controller
    {

        public AppDbContext Db { get; set; }

        public ClasseCompraController(AppDbContext context)
        {
            Db = context;
        }

        public IActionResult List()
        {

            return View(Db.);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(JojoFinancasApp.Models.ClasseCompra model)
        {

            if (!ModelState.IsValid) return View(model);

            _context.Add(model);
            _context.SaveChanges();

            return RedirectToAction(nameof(List));

        }
    }
}