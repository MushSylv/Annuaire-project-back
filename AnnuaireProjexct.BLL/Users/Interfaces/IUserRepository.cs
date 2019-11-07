using AnnuaireProjexct.BLL.Users.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnnuaireProjexct.BLL.Users.Interfaces
{
    public interface IUserRepository
    {
        User GetByLogin(string login, string password);
        bool Create(User user);
    }
}
