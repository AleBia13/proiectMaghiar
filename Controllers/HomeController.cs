using Microsoft.AspNetCore.Mvc;
using proiectMaghiar.Models;
using System.Diagnostics;

namespace proiectMaghiar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

       

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Problem()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Problem(string inputString)
        {
        
            Problem seq = new Problem(inputString);
            seq.inputString = inputString;
            if (seq.inputString != null)
            {
                int n = seq.inputString.Length;
                string res = Convert.ToString(seq.lengthOfLongestSubstring(seq.inputString));
                ViewBag.mesaj = res+" characters";
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}