using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class StudentCourse
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student StudentSCM { get; set; }
        public Course CourseSCM { get; set; }
    }
}
