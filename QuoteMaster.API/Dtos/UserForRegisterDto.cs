using System.ComponentModel.DataAnnotations;

namespace QuoteMaster.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(8, MinimumLength=4, ErrorMessage = "You must specify password between 4 and 8 characters.")]
        public string Password { get; set; }
    }
}