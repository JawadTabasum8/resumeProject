using resumeProject.Data;
using resumeProject.Models;

namespace resumeProject.viewModel
{
    public class HomeVM
    {
        public Profile profile { get; set; }
        public IEnumerable<Experince> experince;
        public IEnumerable<Education> education;
        public IEnumerable<Language> language; 
        public IEnumerable<Skill> skill;
    }
}
 