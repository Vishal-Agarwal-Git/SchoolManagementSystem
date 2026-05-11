using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Data;

namespace SchoolManagementSystem.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext context;

        public CourseController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var course = context.Courses.ToList();
            return View(course);
        }
    }
}
