using AnnuairePorject.Services.Users.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnnuairePorject.Services.Users.Interface
{
    public interface IUserService
    {
        Guid Create(UserInput userInput);
    }
}
