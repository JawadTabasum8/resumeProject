using System.ComponentModel.DataAnnotations;

namespace resumeProject.Models
{
    public class Profile
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Designation { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
