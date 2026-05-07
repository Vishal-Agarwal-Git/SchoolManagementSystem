using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementSystem.Controllers
{
    public class CourseController : Controller
    {
        public CourseController()
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
