using Microsoft.AspNetCore.Mvc;

namespace PhaoHoa.vn.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
