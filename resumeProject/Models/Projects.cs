using System.ComponentModel.DataAnnotations;

namespace resumeProject.Models
{
    public class Projects
    {
        [Key]
        public int id { get; set; }
        
        public string Name { get; set; }
      
        public String Vedio { get; set; }
      
    }
}
