using Microsoft.AspNetCore.Mvc;

namespace PORG6212_Part3_version_3.Controllers
{
    public class HRController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
