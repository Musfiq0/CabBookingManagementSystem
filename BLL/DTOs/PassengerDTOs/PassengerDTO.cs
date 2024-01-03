using BLL.DTOs.BookingDTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.PassengerDTOs
{
    public class PassengerDTO
    {
        public int PId { get; set; }
        [Required]
        [StringLength(20)]
        public string PUName { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        
    }
}
