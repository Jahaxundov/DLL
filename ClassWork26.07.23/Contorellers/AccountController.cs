using Service.Helper;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork26._07._23.Contorellers
{
    public class AccountController
    {
        private readonly AccountService _accountService;

        public AccountController()
        {
            _accountService = new AccountService();
        }
        public void Login()
        {
            Console.WriteLine("Username");
            Username: string username = Console.ReadLine();
            Console.WriteLine("Password");
            string password = Console.ReadLine();
            bool isLogin = _accountService.Login(username,password);

            if (isLogin)
            {
                Console.WriteLine(AccountMessage.LoginSucsses);
            }
            else
            {
                Console.WriteLine(AccountMessage.LoginFailed);
                goto Username;
            }

        }


    }
}
