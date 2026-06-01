namespace SchoolManagementSystem.Models
{
    public class Salary
    {
        public int SalaryId { get; set; }
        public int StaffId { get; set; }
        public string StaffName { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string SalaryMonth { get; set; }

    }
}
