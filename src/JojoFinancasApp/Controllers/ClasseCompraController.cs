using JojoFinancasApp.Data;
using Microsoft.AspNetCore.Mvc;
using JojoFinancasApp.Models;
using Microsoft.EntityFrameworkCore;

namespace JojoFinancasApp.Controllers
{
    public class ClasseCompraController : Controller
    {

        private readonly AppDbContext _context;

        public ClasseCompraController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> List()
        {

            return View(await _context.ClassesCompra.ToListAsync());
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

            _context.ClassesCompra.Add(model);
            _context.SaveChanges();

            return RedirectToAction(nameof(List));

        }

        public IActionResult Delete(int id)
        {

            var classeCompra = _context.ClassesCompra.FirstOrDefault(c => c.Id == id);

            if (classeCompra != null)
            {
                 _context.ClassesCompra.Remove(classeCompra);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(List));

        }

    }
}