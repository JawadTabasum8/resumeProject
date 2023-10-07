using Microsoft.AspNetCore.Mvc;
using resumeProject.Data;
using resumeProject.viewModel;

namespace resumeProject.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext db;
        public HomeController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.profile = db.tbl_Profile.FirstOrDefault();
            homeVM.education = db.tbl_Education.ToList();
            homeVM.skill = db.tbl_Skill.ToList();
            homeVM.experince = db.tbl_Experince.ToList();
            homeVM.language = db.tbl_Language.ToList();
            return View(homeVM);
        }
    }
}
