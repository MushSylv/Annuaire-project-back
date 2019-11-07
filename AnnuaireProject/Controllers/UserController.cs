using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnnuairePorject.Services.Users.Models;
using AnnuairePorject.Services.Users.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnnuaireProject.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(UserInput user)
        {
            var userCreate = _userService.Create(user);
            if (userCreate == null)
            {
                return StatusCode(403, "Erreur sur le code");
            }
            return Ok(userCreate);
        }

        [HttpGet]
        public IActionResult GetUser()
        {
            return Ok();
        }
    }
}