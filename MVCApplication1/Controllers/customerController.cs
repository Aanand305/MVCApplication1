using Microsoft.AspNetCore.Mvc;

namespace MVCApplication1.Controllers
{
    public class customerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
