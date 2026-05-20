namespace SchoolManagementSystem.Models
{
    public class Fees
    {
        public int FeesId { get; set; }
        public int StudentId { get; set; }
        public int FeeAmount { get; set; }
        public double FeeDeposite { get; set; }
        public DateTime DepositeDateTime { get; set; }

    }
}
