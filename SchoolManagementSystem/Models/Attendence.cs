namespace SchoolManagementSystem.Models
{
    public class Attendence
    {
        public int Id { get; set; }
        public int EnrollmentId { get; set; }
        public DateOnly DateArrival { get; set; }
        public DateTime TimeArrival { get; set; }
        public DateOnly DateDepature { get; set; }
        public DateTime TimeDepature { get; set; }
    }
}
