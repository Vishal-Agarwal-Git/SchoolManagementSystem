namespace SchoolManagementSystem.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public ICollection<CourseSubject> courseSubjects { get; set; }
    }
}
