using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementSystem.Controllers
{
    public class StaffController : Controller
    {
        public StaffController()
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
