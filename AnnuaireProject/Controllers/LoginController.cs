using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnnuairePorject.Services.Authentication.Interfaces;
using AnnuairePorject.Services.Authentication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnnuaireProject.Controllers
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public IActionResult Login([FromBody] Credential credential)
        {
            try
            {
                var principal = _loginService.Login(credential);

                if (principal == null)
                {
                    return null;
                }

                return Ok(principal);
            } catch(Exception ex)
            {
                return StatusCode(401);
            }
        }
    }
}