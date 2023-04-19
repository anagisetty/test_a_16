using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test_A_16.Models;

namespace Test_A_16.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignUpController : ControllerBase
    {
        private readonly SignUpContext _context;

        public SignUpController(SignUpContext context)
        {
            _context = context;
        }

        // POST: api/SignUp
        [HttpPost]
        public async Task<ActionResult<SignUp>> PostUser(SignUp signUp)
        {
            // Check if the user already exists
            if (_context.SignUps.Any(x => x.Email == signUp.Email))
            {
                return BadRequest("User already exists");
            }

            _context.SignUps.Add(signUp);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = signUp.Id }, signUp);
        }
    }
}