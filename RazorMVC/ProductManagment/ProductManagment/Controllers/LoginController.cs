using Microsoft.AspNetCore.Mvc;
using ProductManagment.Models;

namespace ProductManagment.Controllers
{
    public class LoginController : Controller
    {
        
        public ActionResult Login()
        {
            return View();
        }
    }
}
