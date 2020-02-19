using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jwt.Model.Models;
using Jwt.Service.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jwt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        IUserRepository _userRepository;
        public AccountController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpPost("login")]
        public JsonResult Login(User user)
        {
            try
            {
                var token = _userRepository.Login(user);
                return new JsonResult(token);
            }
            catch (Exception)
            {

                throw;
            }
          

        }
     
    }
}