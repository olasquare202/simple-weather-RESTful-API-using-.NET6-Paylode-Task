using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class LoginModel
    {



        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        //[Required(ErrorMessage = "User Name is required")]
        //public string? Username { get; set; }

        //[Required(ErrorMessage = "Password is required")]
        //public string? Password { get; set; }
    }
}
