using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Boxetheus.Controllers
{
    public class BoxWorldController : Controller
    {
        // 
        // GET: /BoxWorld/
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /BoxWorld/Welcome/ 
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
