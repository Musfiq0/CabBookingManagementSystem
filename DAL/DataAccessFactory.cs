using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using DAL.Repos.DriverRepos;
using DAL.Repos.OwnerRepos;
using DAL.Repos.PassengerRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Owner, int, Owner> OwnerData() { return new OwnerRepo(); }
        public static IRepo<Passenger, int, Passenger> PassengerData() { return new PassengerRepo(); }
        public static IRepo<Driver, int, Driver> DriverData() { return new DriverRepo(); }
        public static IRepo<Booking, int, Booking> BookingData() { return new BookingRepo(); }

    }
}
