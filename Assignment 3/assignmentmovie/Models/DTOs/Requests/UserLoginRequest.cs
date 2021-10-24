using System.ComponentModel.DataAnnotations;
using assignmentmovie.Controllers;

namespace assignmentmovie.Models.DTOs.Requests {
    public class UserLoginRequest {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}