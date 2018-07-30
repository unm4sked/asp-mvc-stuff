using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.HardwareTown.Web.Controllers
{
    public class StatusCodeController : Controller
    {
        private readonly ILogger _logger;

        public StatusCodeController(ILoggerFactory logger)
        {
            _logger = logger.CreateLogger("Hardware-Town.Controllers.StatusCodeController");
        }
        [Route("/StatusCode/{statusCode}")]
        public IActionResult Index(int statusCode)
        {
            var reExecute = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();

            _logger.LogInformation($"Unexpected Status Code: {statusCode}, OriginalPath: {reExecute.OriginalPath}");
            return View(statusCode);
        }
    }
}
