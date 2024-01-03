
using BLL.DTOs.BookingDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.PassengerDTOs
{
    public class CabBookingDTO : PassengerDTO
    {
        public List<BookingDTO> Bookings { get; set; }

        public CabBookingDTO() {
            Bookings = new List<BookingDTO>();
        }
    }
}
