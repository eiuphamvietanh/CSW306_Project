using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace CSW306_Project.Models
{
    public class Stations
    {
        [Key]
        public int StationID { get; set; }
        public string StationName { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
    }
}
