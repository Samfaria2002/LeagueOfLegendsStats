using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using LeagueProfileStats.Data;

namespace LeagueProfileStats.controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {   

        private readonly DataContext _context;

        public ProfileController(DataContext context) {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProfile()
        {
            return Ok("Profile");
        }
    }
}