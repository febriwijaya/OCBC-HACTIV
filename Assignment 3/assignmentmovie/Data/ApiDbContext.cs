using System;
using MySqlConnector;
using Microsoft.EntityFrameworkCore;
using assignmentmovie.Models;
using MySql.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace assignmentmovie.Data
{
    public class ApiDbContext : IdentityDbContext {
        public virtual DbSet<MovieData> Movie { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options) {
                
            }
    }  
}