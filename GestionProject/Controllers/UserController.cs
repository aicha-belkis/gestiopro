using Microsoft.AspNetCore.Mvc;

namespace GestionProject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
    {
        return View();
    }
}
}

