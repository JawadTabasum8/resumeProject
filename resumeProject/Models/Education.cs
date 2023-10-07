using System.ComponentModel.DataAnnotations;

namespace resumeProject.Models
{
    public class Education
    {
        [Key]
        public int id { get; set; }

        [Display(Name ="Instute Name")]
        [Required(ErrorMessage ="Please Enter Instute Name")]
        public String InstuteName{ get; set; }

        [Display(Name = "Start date")]
        [Required(ErrorMessage = "Please Enter Start Date")]
        public String StartDate{ get; set; }

        [Display(Name = "End Date")]
        [Required(ErrorMessage = "Please Enter End Date")]
        public String EndDate{ get; set; }

        [Required(ErrorMessage = "Please Enter Degree")]
        public String Degree{ get; set; }
    }
}
