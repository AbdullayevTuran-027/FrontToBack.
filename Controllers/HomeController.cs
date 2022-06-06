using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVm homeVm = new HomeVm();   
            homeVm.slider = _context.Sliders.ToList();
            homeVm.pageIntro = _context.PageIntros.FirstOrDefault();
            homeVm.Products= _context.Products.Include(p=>p.Category).ToList();
            homeVm.Categories= _context.Categories.ToList();
            
            
            return View(homeVm);
        }
    }
}
