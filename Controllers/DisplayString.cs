using Microsoft.AspNetCore.Mvc;
using proiectMaghiar.Models;

namespace proiectMaghiar.Controllers
{
    public class DisplayString : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
