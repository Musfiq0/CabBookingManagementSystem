using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.DriverDTOs
{
    public class DriverDTO
    {
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
    }
}
