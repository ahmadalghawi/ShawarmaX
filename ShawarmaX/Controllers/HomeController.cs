using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShawarmaX.Models;
using ShawarmaX.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ShawarmaX.Controllers
{
    public class HomeController : Controller
    {

        readonly IShawarmaRepository _shawarmaRepository;
        

        public HomeController(IShawarmaRepository shawarmaRepository)
        {
            _shawarmaRepository = shawarmaRepository;
            
        }
        public IActionResult Index()
        {
            var homeViewModel = new homeViewModel
            {
                Offers = _shawarmaRepository.Offers
            };

            return View(homeViewModel);
        }
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}



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
