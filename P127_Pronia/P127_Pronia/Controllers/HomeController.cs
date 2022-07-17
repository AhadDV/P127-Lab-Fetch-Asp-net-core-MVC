using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P127_Pronia.DAL;
using P127_Pronia.Models;
using P127_Pronia.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace P127_Pronia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM model = new HomeVM
            {
                Sliders = _context.Sliders.ToList(),
                Plants = _context.Plants.Include(p=>p.PlantImages).ToList()
            };
            return View(model);
        }
    }
}
