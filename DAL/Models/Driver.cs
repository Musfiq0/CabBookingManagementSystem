using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string DUName { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [ForeignKey("Owner")]
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }

}
