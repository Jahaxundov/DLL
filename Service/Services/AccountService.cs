using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AccountService
    {
        public bool Login (string username, string password)
        {
            var dbUsers = GetUsers();
            foreach (User user in dbUsers)
            {
                if(user.UserName==username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        private User[] GetUsers()
        {
            User[] users =
            {
                new User
                {
                    Id=1,
                    UserName="xayyam55",
                    Password="xayyam123"
                    
                },
                new User
                {
                    Id=2,
                    UserName="ismayil55",
                    Password="ismyil123"

                }
            };
            return users;

        } 
    }
}
