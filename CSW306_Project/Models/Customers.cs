using System.ComponentModel.DataAnnotations;

namespace CSW306_Project.Models
{
    public class Customers
    {
        [Key]
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string? Email { get; set; }
        public DateTime RegisterDate { get; set; }
        public string? Address { get; set; }
        public string Role { get; set; }
    }
}
