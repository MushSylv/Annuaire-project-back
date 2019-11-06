using AnnuairePorject.Services.Authentication.Interfaces;
using AnnuairePorject.Services.Authentication.Models;
using AnnuaireProjexct.BLL.Users.Models;
using AnnuaireProjexct.BLL.Users.Interfaces;

namespace AnnuairePorject.Services
{
    public class LoginService : ILoginService
    {
        private readonly IUserBusiness _userBusiness;

        public LoginService(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }
        public User Login(Credential credential)
        {
            var auth = _userBusiness.Authenticate(credential.Login, credential.Password);
            return auth == null ? null : auth;
        }
    }
}
