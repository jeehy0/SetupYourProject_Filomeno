using Microsoft.AspNetCore.Mvc;
using SetupYourProject_Filomeno.Models;

namespace SetupYourProject_Filomeno.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Employee()
        {
            return View();
        }
    }
}
