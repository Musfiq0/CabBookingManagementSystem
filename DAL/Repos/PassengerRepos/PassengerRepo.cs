using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.PassengerRepos
{
    internal class PassengerRepo : Repo, IRepo<Passenger, int, Passenger>
    {
        public Passenger Create(Passenger obj)
        {
            db.Passengers.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Passengers.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Passenger> Read()
        {
            return db.Passengers.ToList();
        }

        public Passenger Read(int id)
        {
            return db.Passengers.Find(id);
        }


        public Passenger Update(Passenger obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }

    }
}
