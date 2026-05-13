using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int CourseFee { get; set; }
        public int Duration { get; set; }
        public string CourseCode { get; set; }
        public ICollection<StudentCourse>? Courses { get; set; }
        public ICollection<CourseBooks> CBooks { get; set; }
        public ICollection<CourseSubject> courseSubjects { get; set; }
    }
}
