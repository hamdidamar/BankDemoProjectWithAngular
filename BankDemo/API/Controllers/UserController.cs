using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService userService;
        public UserController()
        {
            userService = new UserManager(new UserDal());
        }

        [HttpGet("GetAllUsers")]
        public List<User> GetAllUsers()
        {
            return userService.GetAll();
        }

        [HttpGet("GetUserById")]
        public User GetUserById([FromQuery] int userId)
        {
            return userService.Get(u=> u.UserId == userId);
        }

        [HttpPost("AddUser")]
        public string AddUser([FromBody] User user)
        {
            var res = userService.Add(user);
            var message = "";
            if (res == 1)
            {
                message = "User added succesfuly" + " " + "id:" + user.UserId + " " + "name:" + user.UserName;
            }
            else
            {
                message = "User cannot added" + user.UserName;
            }

            return message;
        }

        [HttpPut("UpdateUser")]
        public string UpdateUser([FromBody] User user)
        {
            var res = userService.Update(user);
            var message = "";
            if (res == 1)
            {
                message = "User updated succesfuly" + " " + "id:" + user.UserId + " " + "name:" + user.UserName;
            }
            else
            {
                message = "User cannot updated" + user.UserName;
            }

            return message;
        }

        [HttpDelete("DeleteUser")]
        public string DeleteUser([FromBody] User user)
        {
            var res = userService.Delete(user);
            var message = "";
            if (res == 1)
            {
                message = "User deleted succesfuly";
            }
            else
            {
                message = "User cannot deleted";
            }

            return message;
        }
    }
}
