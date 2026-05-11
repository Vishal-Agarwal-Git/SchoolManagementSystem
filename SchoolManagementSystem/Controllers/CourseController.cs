using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext context;

        public CourseController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var course = context.Courses.ToList();
            return View(course);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Course model)
        {
            if(ModelState.IsValid)
            {
                context.Courses.Add(model);
                context.SaveChanges();
                return RedirectToAction();
            }
            return View(model);
        }
    }
}
