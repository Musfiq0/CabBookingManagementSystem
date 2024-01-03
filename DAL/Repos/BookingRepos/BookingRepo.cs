using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.BookingRepos
{
    internal class BookingRepo : Repo, IRepo<Booking, int, Booking>
    {
        public Booking Create(Booking obj)
        {
            db.Bookings.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Bookings.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Booking> Read()
        {
            return db.Bookings.ToList();
        }

        public Booking Read(int id)
        {
            return db.Bookings.Find(id);
        }

        public Booking Update(Booking obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }

        public Booking CabBooking(string username)
        {
            var data = db.Passengers.FirstOrDefault(u => u.PUName.Equals(username));
            if (data == null) return db.Bookings.Find(username);
            return null;
        }
    }
}
