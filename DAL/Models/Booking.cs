using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public DateTime PickupTime { get; set; }
        public string PickupLocation { get; set; }
        public string Destination { get; set; }

        [ForeignKey("Driver")]
        public int? DriverId { get; set; } 
        [ForeignKey("Passenger")]
        public int PassengerId { get; set; }
        public Driver Driver { get; set; }
        public Passenger Passenger { get; set; }
    }


}
