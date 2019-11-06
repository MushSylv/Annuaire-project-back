using AnnuaireProjexct.BLL.Users.Interfaces;
using AnnuaireProjexct.BLL.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnnuaireProject.DAL.Users
{
    public class InMemoryUserRepository: IUserRepository
    {
        private List<User> users;

        public InMemoryUserRepository()
        {
            users = new List<User>
            {
                new User("zizi", "poilu")
            };
                
        }

        public Guid Create(string login, string password)
        {
            var user = users.FirstOrDefault(u => u.Login == login && u.Password == password);
            if (user != null)
            {
                return ;
            }
            return user.Id;
        }

        public User GetByLogin(string login, string password)
        {
            var user = users.FirstOrDefault(u => u.Login == login && u.Password == password);
            return user == null ? null : user;

        }
    }
}
