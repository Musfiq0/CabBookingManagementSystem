using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.OwnerDTOs
{
    public class OwnerDTO
    {
        public int Id { get; set; }
        [Required]
        public string OUName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
    }
}
