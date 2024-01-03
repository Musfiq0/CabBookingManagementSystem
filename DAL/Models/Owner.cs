using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Owner
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string OUName { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public ICollection<Driver> Drivers { get; set; }
    }

}
