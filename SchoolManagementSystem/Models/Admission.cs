namespace SchoolManagementSystem.Models
{
    public class Admission
    {
        public int id { get; set; }
        public string name { get; set; }
        public string CourseId { get; set; }
        public int FormFees { get; set; }
        public DateTime Date_Time { get; set; }
        public string PaidSourse { get; set; }
        public int StaffId { get; set; }
    }
}
