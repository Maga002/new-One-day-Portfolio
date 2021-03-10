using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web1.Models;
using Web1.ViewModel;

namespace Web1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            HomeVm vm = new HomeVm();
            vm.Sect1s = _context.Sect1s.First();
            vm.Sect2s = _context.Sect2s.First();
            vm.Sect3s = _context.Sect3s.ToList();
            vm.Sect4s = _context.Sect4s.ToList();
            vm.Sect5s = _context.Sect5s.ToList();
            vm.Sect6s = _context.Sect6s.First();
            vm.Sect7s = _context.Sect7s.ToList();

            return View(vm);
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
