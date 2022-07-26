using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TforT.Models;
using TforT.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TforT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public List<User> Get()
        {
            var result = _userService.GetUser();
            return result;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            var result = _userService.GetUser(id);
            return result;
        }

        // POST api/<UserController>
        [HttpPost]
        public bool Post([FromBody] User user)
        {
            var result = _userService.add(user);
            return result;
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public bool Put([FromBody] User user)
        {
            var result = _userService.Edit(user);
            return result;
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var result = _userService.Delete(id);
            return result;
        }
    }
}
