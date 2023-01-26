using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class RegisterModel
    {

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }







        //[Required(ErrorMessage = "User Name is required")]
        //public string? Username { get; set; }

        //[EmailAddress]
        //[Required(ErrorMessage = "Email is required")]
        //public string? Email { get; set; }

        //[Required(ErrorMessage = "Password is required")]
        //public string? Password { get; set; }
    }
}
