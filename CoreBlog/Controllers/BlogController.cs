using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
