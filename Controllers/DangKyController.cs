using Microsoft.AspNetCore.Mvc;

namespace BT_C.Controllers
{
    public class DangKyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
