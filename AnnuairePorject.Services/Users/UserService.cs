using AnnuairePorject.Services.Users.Interface;
using AnnuairePorject.Services.Users.Models;
using AnnuaireProjexct.BLL.Users.Business;
using AnnuaireProjexct.BLL.Users.Interfaces;
using AnnuaireProjexct.BLL.Users.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnnuairePorject.Services.Users
{
    public class UserService: IUserService

    {
        private readonly IUserBusiness _userBusiness;

        public UserService(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }

        public Guid Create(UserInput userInput)
        {
            var user = new User(userInput.Login, userInput.Password);
            _userBusiness.Create(user);
            return user.Id;
        }
    }
}
