using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage = "Please fill in Username")]
        public string Username {get; set;}

        [Required]
        [StringLength(8, MinimumLength = 5, ErrorMessage = "You Must Specify password between 4 and 8 characters")]
        public string Password {get; set;}
    }
}