namespace SchoolManagementSystem.Models
{
    public class CourseBooks
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int BooksId { get; set; }
        public Books Books { get; set; }
    }
}
