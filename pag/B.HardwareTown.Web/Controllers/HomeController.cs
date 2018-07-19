using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using B.HardwareTown.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using B.HardwareTown.Infrastructure.Repositories;
using B.HardwareTown.ApplicationCore.Repositories;

namespace B.HardwareTown.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;
        public HomeController(ILoggerFactory logger)
        {
            _logger = logger.CreateLogger("Hardware-Town.Controllers.HomeController");

        }
        public IActionResult Index()
        {
            _logger.LogDebug("Welcome to index page");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var mess = new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier };
            _logger.LogError($"An error occurred while processing your request.  Request ID: {mess.RequestId.ToString()} ");
            return View();
        }
    }
}