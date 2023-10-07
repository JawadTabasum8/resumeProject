using System.ComponentModel.DataAnnotations;

namespace resumeProject.viewModel
{
    public class ProfileVM
    {

        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="Please Enter Name")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please Enter Designation")]
        public string Designation { get; set; }
        [Required(ErrorMessage = "Please Enter Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Upload Image")]
        public IFormFile Image { get; set; }
        [Required(ErrorMessage = "Please Enter User Name")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }
        [Display (Name="Confirm Password")]
        [Compare("Password",ErrorMessage ="Password and Confirm Password not match")]
        public string CPassword { get; set; }
        public string OldImage { get; set; }
    }
}
