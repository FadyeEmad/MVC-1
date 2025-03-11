using Microsoft.AspNetCore.Mvc;
using MVC_1.Models;
using System.Diagnostics;

namespace MVC_1.Controllers
{
    public class HomeController : Controller
    {

        public ContentResult ShowMessage()
        {
            ContentResult result = new ContentResult();
            result.Content = "Hello Fady";
            return result;
        }

        public ViewResult ShowView()
        {
            ViewResult result = new ViewResult();
            result.ViewName = "View1";
            return result;
        }

        public IActionResult ShowMix(int Id)
        {
            if (Id % 2 == 0)
            {
                ContentResult result = new ContentResult();
                result.Content = "Hello Fady";
                return result;
            }
            else
            {
                ViewResult result = new ViewResult();
                result.ViewName = "View1";
                return result;
            }
        }

        public IActionResult ShowMix2(int Id)
        {
            if (Id % 2 == 0)
            {
                return View("View1");
            }
            else
            {
                return Content("Hello World");
            }
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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
