using System.ComponentModel.DataAnnotations;

namespace CSW306_Project.Models
{
    public class Rentals
    {
        [Key]
        public int RentalID { get; set; }
        public int CustomerID { get; set; }
        public int BikeID { get; set; }
        public int StartStationID { get; set; }
        public int EndStationID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal TotalCost { get; set; }
        public string Status { get; set; }
    }
}
