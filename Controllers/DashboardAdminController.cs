using Microsoft.AspNetCore.Mvc;

namespace PROJECT_CAREERCIN.Controllers
{
    public class DashboardAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
