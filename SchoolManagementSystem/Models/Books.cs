namespace SchoolManagementSystem.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string ISBNCode { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string AuthorId { get; set; }
        
    }
}
