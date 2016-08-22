using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        private Database db = new Database();
        public bool Create(ApplicationUser user)
        {
            bool status = false;
            if(user != null)
            {
                user.IsActive = false;
                user.DateCreated = DateTime.Now;
                db.Users.Add(user);
                db.SaveChanges();
                status = true;
            }

            return status;
        }

        public bool Delete(string userID)
        {
            bool status = false;
            ApplicationUser dbUser = db.Users.FirstOrDefault(c => c.Id == userID);
            if(dbUser != null)
            {
                dbUser.IsActive = false;
                db.SaveChanges();
                status = true;
            }
            return status;
        }

        public bool Edit(ApplicationUser user)
        {
            bool status = false;
            if(user != null)
            {
                ApplicationUser dbUser = db.Users.FirstOrDefault(c => c.Id == user.Id);
                db.Entry(dbUser).CurrentValues.SetValues(user);
                db.SaveChanges();
                status = true;
            }

            return status;
        }

        public List<ApplicationUser> GetAll()
        {
            return db.Users.ToList();
        }
       
        public ApplicationUser GetByID(string userID)
        {
            return db.Users.FirstOrDefault(c => c.Id == userID);
        }

        public ApplicationUser GetByUsername(string userName)
        {
            return db.Users.FirstOrDefault(c => c.UserName == userName);
        }
    }
}
