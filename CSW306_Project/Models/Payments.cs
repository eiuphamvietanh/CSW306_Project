using System.ComponentModel.DataAnnotations;

namespace CSW306_Project.Models
{
    public class Payments
    {
        [Key]
        public int PaymentID { get; set; }
        public int RentalID { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string Method { get; set; }
    }
}
