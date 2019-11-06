using AnnuairePorject.Services.Authentication.Models;
using AnnuaireProjexct.BLL.Users.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnnuairePorject.Services.Authentication.Interfaces
{
    public interface ILoginService
    {
        User Login(Credential credential);
    }
}
