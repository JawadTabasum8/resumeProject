using System.ComponentModel.DataAnnotations;

namespace resumeProject.viewModel
{
    public class ProjectsVM
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = " Please Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Upload Vedio")]
        public IFormFile Vedio { get; set; }
        public string OldVedio { get; set; }

    }
}
