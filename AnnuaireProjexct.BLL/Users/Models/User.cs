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

        public User(Guid id, string login, string password)
        {
            Id = id;
            Login = login;
            Password = password;
        }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
