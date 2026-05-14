namespace SchoolManagementSystem.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public int Marks { get; set; }
        public Student Student { get; set; }
    }
}
