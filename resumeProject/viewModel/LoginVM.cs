using System.ComponentModel.DataAnnotations;

namespace resumeProject.viewModel
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Please Enter Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
