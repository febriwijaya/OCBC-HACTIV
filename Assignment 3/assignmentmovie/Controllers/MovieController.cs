using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using assignmentmovie.Models;
using assignmentmovie.Data;
using assignmentmovie.Configuration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.Json;
using Swashbuckle.AspNetCore;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace assignmentmovie.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class MovieController : ControllerBase {
        private readonly ApiDbContext _context;
        public MovieController(ApiDbContext context) {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetMovie() {
            var pay = await _context.Movie.ToListAsync();
            return Ok(pay);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(MovieData data) {
            if(ModelState.IsValid) {
                await _context.Movie.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(CreateMovie), new {data.Id}, data);
            }
            return new JsonResult("Something went wrong") {StatusCode = 500};
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovie(int id) {
            var pay = await _context.Movie.FirstOrDefaultAsync(x => x.Id == id);

            if(pay == null)
                return NotFound();

            return Ok(pay);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovie(int id, MovieData pay) {
            if(id != pay.Id)
                return BadRequest();
            
            var existPay = await _context.Movie.FirstOrDefaultAsync(x => x.Id == id);

            if(existPay == null)
                return NotFound();

            existPay.Name = pay.Name;
            existPay.Genre = pay.Genre;
            existPay.Duration = pay.Duration;
            existPay.ReleaseDate = pay.ReleaseDate;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id) {
            var existPay = await _context.Movie.FirstOrDefaultAsync(x => x.Id == id);

            if(existPay == null)
                return NotFound();

            _context.Movie.Remove(existPay);
            await _context.SaveChangesAsync();

            return Ok(existPay);
        }
    }
}


