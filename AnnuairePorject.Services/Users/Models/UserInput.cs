using System;
using System.Collections.Generic;
using System.Text;

namespace AnnuairePorject.Services.Users.Models
{
    public class UserInput
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public UserInput(string login, string password)
        {
            Id = Guid.NewGuid();
            Login = login;
            Password = password;
        }
    }
}
