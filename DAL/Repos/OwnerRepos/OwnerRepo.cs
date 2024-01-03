using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.OwnerRepos
{
    internal class OwnerRepo : Repo, IRepo<Owner, int, Owner>
    {
        public Owner Create(Owner obj)
        {
            db.Owners.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Owners.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Owner> Read()
        {
            return db.Owners.ToList();
        }

        public Owner Read(int id)
        {
            return db.Owners.Find(id);
        }

        public Owner Update(Owner obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }
    }
}
