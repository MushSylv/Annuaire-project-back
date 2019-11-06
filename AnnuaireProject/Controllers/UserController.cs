using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnnuairePorject.Services.User.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnnuaireProject.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpPost]
        [Route("create")]
        public IActionResult Create(UserInput user)
        {
            return Ok();
        }
    }
}