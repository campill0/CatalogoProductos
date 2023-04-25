using CatalogoProductos.Data;
using CatalogoProductos.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CatalogoProductos.Controllers
{
    public class ProductosController : Controller
    {
        private readonly CatalogoProductosDbContext _context;

        public ProductosController(CatalogoProductosDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            var productos = _context.Productos.ToList();
            return View(productos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var producto = _context.Productos.Find(id);
            return View(producto);
        }

        [HttpPost]
        public IActionResult Edit(Producto producto)
        {
            _context.Productos.Update(producto);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var producto = _context.Productos.Find(id);
            return View(producto);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var producto = _context.Productos.Find(id);
            _context.Productos.Remove(producto);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
