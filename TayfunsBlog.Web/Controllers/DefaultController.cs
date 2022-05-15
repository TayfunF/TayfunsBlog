using Microsoft.AspNetCore.Mvc;

namespace TayfunsBlog.Web.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
