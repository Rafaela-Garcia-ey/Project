using Microsoft.AspNetCore.Mvc;

namespace LoginPage.Views.LoginP
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
