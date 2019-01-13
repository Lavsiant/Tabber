using GuitarTabberWebApp.Helpers;
using GuitarTabberWebApp.Services.Interfaces;
using GuitarTabberWebApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Model.UserModel;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GuitarTabberWebApp.Controllers
{
    [Route("api/[controller]")]
    public class IdentityController : Controller
    {
        private readonly IIdentityService _identityService;

        public IdentityController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody]User model)
        {
            var user = await _identityService.Authenticate(model.UserName, model.Password);

            if (user == null)
                return BadRequest("Username or password is incorrect");

            var appSettings = new AppSettings();
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("aaa123aaa");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.ID.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            // var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = model.UserName;

            // return basic user info (without password) and token to store client side
            return Ok(new
            {
                Id = user.ID,
                Username = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Token = tokenString,
                IsAdmin = user.IsAdmin
            });
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody]User user)
        {
            try
            {
                // save 
                await _identityService.Create(user);
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("all")]
        public async Task<List<User>> GetUsers(string userName)
        {
            var result = await _identityService.GetAllUsers();
            return result;
        }

        [HttpGet]
        [Route("user-name")]
        public async Task<IActionResult> GetUser(string userName)
        {
            var result = await _identityService.GetUser(userName);
            return Ok(result);
        }

        [HttpGet]
        [Route("user-id")]
        public async Task<IActionResult> GetUser(int id)
        {
            var result = await _identityService.GetUser(id);
            return Ok(result);
        }

        [HttpGet]
        [Route("user-course")]
        public async  Task<IActionResult> GetUserWithCourses(string userName)
        {
            var result = await _identityService.GetUserWithCourses(userName);
            return Ok(result);
        }

        [HttpGet]
        [Route("user-tab")]
        public async  Task<IActionResult> GetUserWithTabs(string userName)
        {
            var result = await _identityService.GetUserWithTabs(userName);
            return Ok(result);
        }


        [HttpGet]
        [Route("user-full")]
        public async  Task<IActionResult> GetUserFullInfo(string userName)
        {
            var result = await _identityService.GetUserFullInfo(userName);
            return Ok(result);
        }
    }
}
