using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Passenger
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string PUName { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        
        public ICollection<Booking> Bookings { get; set; }
    }

}
