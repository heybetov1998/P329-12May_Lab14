using Microsoft.AspNetCore.Mvc;

namespace P329_12May_Lab14.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
