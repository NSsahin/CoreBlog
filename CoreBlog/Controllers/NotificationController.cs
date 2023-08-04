using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
