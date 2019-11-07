using System;
using System.Collections.Generic;
using System.Text;

namespace AnnuaireProjexct.BLL.Users.Models
{
    public class User
    {

        public Guid Id { get; }
        public string Login { get; }
        public string Password { get; }

        public User(string login, string password)
        {
            Id = Guid.NewGuid();
            Login = login;
            Password = password;
        }

    }
}
