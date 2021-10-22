using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaymentApi.Models;
using PaymentApi.Data;
using PaymentApi.Configuration;
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

namespace PaymentApi.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PaymentDetailController : ControllerBase {
        private readonly ApiDbContext _context;
        public PaymentDetailController(ApiDbContext context) {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetPayments() {
            var pay = await _context.PaymentDetail.ToListAsync();
            return Ok(pay);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePayment(PaymentDetailData data) {
            if(ModelState.IsValid) {
                await _context.PaymentDetail.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(CreatePayment), new {data.paymentDetailId}, data);
            }
            return new JsonResult("Something went wrong") {StatusCode = 500};
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPayment(int id) {
            var pay = await _context.PaymentDetail.FirstOrDefaultAsync(x => x.paymentDetailId == id);

            if(pay == null)
                return NotFound();

            return Ok(pay);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePayment(int id, PaymentDetailData pay) {
            if(id != pay.paymentDetailId)
                return BadRequest();
            
            var existPay = await _context.PaymentDetail.FirstOrDefaultAsync(x => x.paymentDetailId == id);

            if(existPay == null)
                return NotFound();

            existPay.cardOwnerName = pay.cardOwnerName;
            existPay.cardNumber = pay.cardNumber;
            existPay.expirationDate = pay.expirationDate;
            existPay.securityCode = pay.securityCode;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePayment(int id) {
            var existPay = await _context.PaymentDetail.FirstOrDefaultAsync(x => x.paymentDetailId == id);

            if(existPay == null)
                return NotFound();

            _context.PaymentDetail.Remove(existPay);
            await _context.SaveChangesAsync();

            return Ok(existPay);
        }
    }
}


