using System;
using System.Collections.Generic;
using System.Text;

namespace AnnuairePorject.Services.Users.Models
{
    public class UserInput
    {
        public UserInput()
        {

        }

        public UserInput(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public string Login { get; set; }
        public string Password { get; set; }

        
    }
}
