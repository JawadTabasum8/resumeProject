using System.ComponentModel.DataAnnotations;

namespace resumeProject.Models
{
    public class Experince
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Job Title")]
        [Required(ErrorMessage = "Please Enter Job Title")]
        public string JobTitle { get; set; }

        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Please Enter Start Date")]
        public string StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required(ErrorMessage = "Please Enter Start Date")]
        public string EndDate { get; set; }

        [Required(ErrorMessage = "Please Enter Description")]
        public string Description  { get; set; }
    }
}
