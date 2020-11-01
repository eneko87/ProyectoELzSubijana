using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoELzSubijana.Data;
using ProyectoELzSubijana.Models;

namespace ProyectoELzSubijana.Controllers
{
    public class HomeController : Controller
    {

        // public IActionResult Index()
        //{
        //    return View();
        //}

        /* De aqui en adelante: se añade código para mostrar imagenes de los productos existentes
            en la base de datos */
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index() // Se anula retornar solo la vista de Index, para generar la vista de Index con los productos
        {
            return View(await _context.Producto.ToListAsync());
        }
        // Fin de comentario

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
