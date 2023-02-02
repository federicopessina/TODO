using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TODO.Models;

namespace TODO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Index Controller.
        /// </summary>
        /// <returns>View.</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Privacy Controller.
        /// </summary>
        /// <returns>View.</returns>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// Error Controller. Called when the user calls something that does not exists.
        /// </summary>
        /// <returns>View.</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
