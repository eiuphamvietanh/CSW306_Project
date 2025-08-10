using System.ComponentModel.DataAnnotations;

namespace CSW306_Project.Models
{
    public class Bikes
    {
        [Key]
       public int BikeID { get; set; }
       public string BikeCode { get; set; }
       public string Model { get; set; }
       public string Status { get; set; }
       public decimal Price { get; set; }
       public int StationID { get; set; }


    }
}
