﻿using MicroServices.IdentityServer.Dtos;
using MicroServices.IdentityServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MicroServices.IdentityServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpPost]
        public async Task<IActionResult> SingUp(SignUpDto signUpDto)
        {
            var user = new ApplicationUser
            {
                UserName = signUpDto.Username,
                Email = signUpDto.Email,
                City = signUpDto.City,
            };
            var result = await _userManager.CreateAsync(user, signUpDto.Password);
            if (result.Succeeded)
            {
                return Ok("Kullanıcı kaydı oluşturuldu");
            }
            else
            {
                return Ok("Bir Hata Oluştu");
            }
        }
    }
}
