using AnnuaireProjexct.BLL.Users.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnnuaireProjexct.BLL.Users.Interfaces
{
    public interface IUserBusiness
    {
        User Authenticate(string login, string password);
        Guid Create(User user);
    }
}
