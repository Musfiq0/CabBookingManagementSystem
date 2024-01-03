using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CBMSContext : DbContext
    {
        public DbSet<Owner> Owners { get; set; }

        public DbSet<Passenger> Passengers { get; set; }

        public DbSet<Driver> Drivers { get; set; }

        public DbSet<Booking> Bookings { get; set; }
        
        public DbSet<User> Users { get; set; }
    }
}
