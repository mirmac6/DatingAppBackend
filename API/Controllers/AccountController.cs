using API.Data;
using API.DTOs;
using API.Entities;
using API.Helpers;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public AccountController(UserManager<AppUser> userManager, ITokenService tokenService,IMapper mapper)
        {
            _userManager = userManager;
            _tokenService = tokenService;
            _mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDTO>> Register(RegisterDTO RegisterDTO)
        {
            if (await UserExists(RegisterDTO.Username)) return BadRequest("Username is taken.");

            var user = _mapper.Map<AppUser>(RegisterDTO);


            user.UserName = RegisterDTO.Username.ToLower();

            var result = await _userManager.CreateAsync(user, RegisterDTO.Password);

            if (!result.Succeeded) return BadRequest(result.Errors);

            var roleResult = await _userManager.AddToRoleAsync(user, "Member");

            if (!roleResult.Succeeded) return BadRequest(result.Errors);

            return new UserDTO 
            { 
                Username=user.UserName,
                Token = await _tokenService.CreateToken(user),
                KnownAs = user.KnownAs,
                Gender = user.Gender
            };
        }
        
        [HttpPost("login")]
        public async Task<ActionResult<UserDTO>> Login(LoginDTO LoginDTO)
        {
            var user = await _userManager.Users.Include(p=>p.Photos).SingleOrDefaultAsync(x => x.UserName == LoginDTO.Username);
            if (user == null) return Unauthorized("Invalid username!");

            var result = await _userManager.CheckPasswordAsync(user, LoginDTO.Password);

            if (!result) return Unauthorized("Invalid password");

            return new UserDTO
            {
                Username = user.UserName,
                Token = await _tokenService.CreateToken(user),
                PhotoUrl = user.Photos.FirstOrDefault(x => x.IsMain)?.Url,
                KnownAs = user.KnownAs,
                Gender = user.Gender
            };
        }

        private async Task<bool> UserExists(string username)
        {
            return await _userManager.Users.AnyAsync(x=> x.UserName == username.ToLower());
        }
    }
}
