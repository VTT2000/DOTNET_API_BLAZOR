//api-controller
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapi_blazor.models.EbayDB;
//using webapi_blazor.Models;

namespace webapi_blazor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly EbayContext _context;
        public UserController(EbayContext db)
        {
            _context = db;
        }

        [HttpGet("/user/getall")]
        public IActionResult Get()
        {
            return Ok(_context.Users.Skip(0).Take(10));
        }

        
        
    }
}