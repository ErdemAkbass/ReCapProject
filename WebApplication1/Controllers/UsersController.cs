using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUsersService _userService;

        public UsersController(IUsersService usersService)
        {
            _userService = usersService;
        }
        [HttpGet]
        [Route("getAll")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            return Ok(result);
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(User user)
        {
            var result = _userService.Add(user);
            return Ok(result);
        }


    }
}
