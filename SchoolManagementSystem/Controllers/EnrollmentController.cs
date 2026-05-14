using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Data;

namespace SchoolManagementSystem.Controllers
{
    public class EnrollmentController : Controller
    {
        private readonly ApplicationDbContext context;

        public EnrollmentController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var Enroll = context.Students.ToList();
            return View(Enroll);
        }
    }
}
