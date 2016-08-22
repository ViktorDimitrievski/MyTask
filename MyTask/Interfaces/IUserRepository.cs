using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IUserRepository
    {
        List<ApplicationUser> GetAll();
        ApplicationUser GetByID(string userID);

        ApplicationUser GetByUsername(string userName);
        bool Create(ApplicationUser user);
        bool Edit(ApplicationUser user);
        bool Delete(string userID);

    }
}
