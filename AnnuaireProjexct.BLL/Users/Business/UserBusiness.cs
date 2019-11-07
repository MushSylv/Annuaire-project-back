using AnnuaireProjexct.BLL.Users.Interfaces;
using AnnuaireProjexct.BLL.Users.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnnuaireProjexct.BLL.Users.Business
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepository _userRepository;

        public UserBusiness(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Authenticate(string login, string password)
        {
            var auth = _userRepository.GetByLogin(login, password);
            return auth == null ? null : auth;
        }

        public Guid Create(User user)
        {
           var userFind = _userRepository.Create(user);
           if (userFind == false)
            {
                throw new Exception("Cet utilisateur existe déja");
            } 
            return user.Id;
        }
    }
}
