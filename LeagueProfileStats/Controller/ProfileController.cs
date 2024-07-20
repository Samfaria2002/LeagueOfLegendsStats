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
using LeagueProfileStats.Model;

namespace LeagueProfileStats.controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly DataContext _context;
        public readonly PlayerProfile _profile;

        public ProfileController(DataContext context, PlayerProfile profile)
        {
            _context = context;
            _profile = profile;
        }

        [HttpGet]
        public PlayerProfile[] GetProfile()
        {
            IQueryable<PlayerProfile> query = _context.ProfileContext;

            query = query.AsNoTracking().OrderBy(res => res.Id);
            return query.ToArray();
        }

        [HttpGet("{id}")]
        public PlayerProfile GetProfileById(int id) {
            IQueryable<PlayerProfile> query = _context.ProfileContext;
        
            query = query.AsNoTracking().Where(res => res.Id == id);
        
            return query.FirstOrDefault();
        }

        [HttpPost]
        public IActionResult PostProfile(PlayerProfile profile) {
            
            _context.ProfileContext.Add(profile);
            _context.SaveChanges();
            return Created($"/api/profile/{profile.Id}", profile);
        }
    }
}
