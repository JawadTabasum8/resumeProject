using System.ComponentModel.DataAnnotations;

namespace resumeProject.Models
{
    public class Skill
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="Please Enter Name")]  
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Percentage")]
        [Range(0,100)]  
        public int Percentage { get; set; }
    }
}
