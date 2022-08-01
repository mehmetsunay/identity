using Microsoft.AspNetCore.Mvc;

namespace identity.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
