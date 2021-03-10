using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web1.ViewModel;

namespace Web1.Areas.OnedayPortAdmin.Controllers
{
    [Area("OnedayPortAdmin")]
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
            return View(vm);
        }
    }
}
