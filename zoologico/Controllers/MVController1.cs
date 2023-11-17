using Microsoft.AspNetCore.Mvc;

namespace zoologico.Controllers
{
    public class MVController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
