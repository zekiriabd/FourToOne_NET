using Microsoft.AspNetCore.Mvc;
using ProductManagment.Models;

namespace ProductManagment.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error(int statusCode)
        { 
            return View(new ErrorViewModel() { RequestId = statusCode.ToString() });
        }
    }
}
