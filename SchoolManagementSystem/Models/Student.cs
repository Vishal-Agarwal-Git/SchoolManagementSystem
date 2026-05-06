using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime StudentDate { get; set; } = DateTime.Now;
        public ICollection<StudentCourse> Courses { get; set; } = new HashSet<StudentCourse>();
    }
}
