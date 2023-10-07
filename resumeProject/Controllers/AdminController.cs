using Microsoft.AspNetCore.Mvc;
using resumeProject.Data;
using resumeProject.Models;
using resumeProject.viewModel;
using System.Net.WebSockets;

namespace resumeProject.Controllers
{
    public class AdminController : Controller
    {
        AppDbContext db;
        IWebHostEnvironment env;
        public AdminController(AppDbContext _db, IWebHostEnvironment _env)
        {
            db = _db;
            env = _env;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Flag") == "true")
            {
                ViewData["userName"] = HttpContext.Session.GetString("Name");
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Userid"] = HttpContext.Session.GetInt32("Userid");
                ViewData["Vedio"] = HttpContext.Session.GetInt32("Vedio");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }
        //.............................................skill
        public IActionResult Skill()
        {
            if (HttpContext.Session.GetString("Flag") == "true")
            {
                ViewData["userName"] = HttpContext.Session.GetString("Name");
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Userid"] = HttpContext.Session.GetInt32("Userid");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }
        [HttpPost]
        public IActionResult Skill(Skill skill)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Skill.Add(skill);
                db.SaveChanges();
                return RedirectToAction("ShowSkill");
            }
            return View();
        }
        //.............................................ShowSkill
        public IActionResult ShowSkill()
        {
            if (HttpContext.Session.GetString("Flag") == "true")
            {
                ViewData["userName"] = HttpContext.Session.GetString("Name");
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Userid"] = HttpContext.Session.GetInt32("Userid");
                var myskill = db.tbl_Skill;
                return View(myskill);
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }
        //............................................Delete Skill
        public IActionResult DeleteSkill(int id)
        {
            ViewData["userName"] = HttpContext.Session.GetString("Name");
            ViewData["Image"] = HttpContext.Session.GetString("Image");
            ViewData["Userid"] = HttpContext.Session.GetInt32("Userid");
            var SkillToDell = db.tbl_Skill.Find(id);
            db.tbl_Skill.Remove(SkillToDell);
            db.SaveChanges();
            return RedirectToAction("ShowSkill");
        }
        //............................................Update Skill
        public IActionResult UpdateSkill(int id)
        {
            if (HttpContext.Session.GetString("Flag") == "true")
            {
                ViewData["userName"] = HttpContext.Session.GetString("Name");
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Userid"] = HttpContext.Session.GetInt32("Userid");
                var DataToUpdate = db.tbl_Skill.Find(id);
                return View(DataToUpdate);
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }
        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            ViewData["userName"] = HttpContext.Session.GetString("Name");
            ViewData["Image"] = HttpContext.Session.GetString("Image");
            ViewData["Userid"] = HttpContext.Session.GetInt32("Userid");
            db.tbl_Skill.Update(skill);
            db.SaveChanges();

            return RedirectToAction("ShowSkill");

        }
        //................................................Language....................................................................

        public IActionResult Language()
        {
            if (HttpContext.Session.GetString("Flag") == "true")
            {
                ViewData["userName"] = HttpContext.Session.GetString("Name");
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Userid"] = HttpContext.Session.GetInt32("Userid");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }

        [HttpPost]
        public IActionResult Language(Language language)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Language.Add(language);
                db.SaveChanges();
                return RedirectToAction("ShowLanguage");
            }
            return View();
        }
        //.............................................Show Language
        public IActionResult ShowLanguage()
        {
            if (HttpContext.Session.GetString("Flag") == "true")
            {
                ViewData["userName"] = HttpContext.Session.GetString("Name");
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Userid"] = HttpContext.Session.GetInt32("Userid");
                var mylanguage = db.tbl_Language;
                return View(mylanguage);
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }

        //............................................Delete Language
        public IActionResult DeleteLanguage(int id)
        {
            if (HttpContext.Session.GetString("Flag") == "true")
            {
                ViewData["userName"] = HttpContext.Session.GetString("Name");
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Userid"] = HttpContext.Session.GetInt32("Userid");
                var LanguageToDell = db.tbl_Language.Find(id);
                db.tbl_Language.Remove(LanguageToDell);
                db.SaveChanges();
                return RedirectToAction("ShowLanguage");
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }
        //............................................Update Language
        public IActionResult UpdateLanguage(int id)
        {
            var DataToUpdate = db.tbl_Language.Find(id);
            return View(DataToUpdate);
        }
        [HttpPost]
        public IActionResult UpdateLanguage(Language language)
        {
            if (HttpContext.Session.GetString("Flag") == "true")
            {
                ViewData["userName"] = HttpContext.Session.GetString("Name");
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Userid"] = HttpContext.Session.GetInt32("Userid");
                db.tbl_Language.Update(language);
                db.SaveChanges();
                return RedirectToAction("ShowLanguage");
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }
        //.......................................................Education..............................................................

        public IActionResult Education()
        {
            if (HttpContext.Session.GetString("Flag") == "true")
            {
                ViewData["userName"] = HttpContext.Session.GetString("Name");
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Userid"] = HttpContext.Session.GetInt32("Userid");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }
        [HttpPost]
        public IActionResult Education(Education education)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Education.Add(education);
                db.SaveChanges();
                return RedirectToAction("ShowEducation");
            }
            return View();
        }
        //...............................................ShowEducation
        public IActionResult ShowEducation()
        {
            if (HttpContext.Session.GetString("Flag") == "true")
            {
                ViewData["userName"] = HttpContext.Session.GetString("Name");
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Userid"] = HttpContext.Session.GetInt32("Userid");
                var EducaionToShow = db.tbl_Education;
                return View(EducaionToShow);
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }

        //...............................................DeleteEducation
        public IActionResult DeleteEducation(int id)
        {
            var EduToDell = db.tbl_Education.Find(id);
            db.tbl_Education.Remove(EduToDell);
            db.SaveChanges();
            return RedirectToAction("ShowEducation");
        }
        //................................................UpdaeEducation
        public IActionResult UpdateEducation(int id)
        {
            if (HttpContext.Session.GetString("Flag") == "true")
            {
                ViewData["userName"] = HttpContext.Session.GetString("Name");
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Userid"] = HttpContext.Session.GetInt32("Userid");
                var EduToUpdate = db.tbl_Education.Find(id);
                return View(EduToUpdate);
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }
        [HttpPost]
        public IActionResult UpdateEducation(Education education)
        {
            db.tbl_Education.Update(education);
            db.SaveChanges();
            return RedirectToAction("ShowEducation");
        }
        //..........................................................Experiance............................................


        public IActionResult Experiance()
        {
            if (HttpContext.Session.GetString("Flag") == "true")
            {
                ViewData["userName"] = HttpContext.Session.GetString("Name");
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Userid"] = HttpContext.Session.GetInt32("Userid");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }

        [HttpPost]
        public IActionResult Experiance(Experince experiance)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Experince.Add(experiance);
                db.SaveChanges();
                return RedirectToAction("ShowExperiance");
            }
            return View();
        }
        //.............................................Show Experiance
        public IActionResult ShowExperiance()
        {
            if (HttpContext.Session.GetString("Flag") == "true")
            {
                ViewData["userName"] = HttpContext.Session.GetString("Name");
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Userid"] = HttpContext.Session.GetInt32("Userid");
                var myExperiance = db.tbl_Experince;
                return View(myExperiance);
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }

        //............................................Delete Experiance
        public IActionResult DeleteExperiance(int id)
        {
            var ExpToDell = db.tbl_Experince.Find(id);
            db.tbl_Experince.Remove(ExpToDell);
            db.SaveChanges();
            return RedirectToAction("ShowExperiance");
        }
        //............................................Update Experiance
        public IActionResult UpdateExperiance(int id)
        {
            if (HttpContext.Session.GetString("Flag") == "true")
            {
                ViewData["userName"] = HttpContext.Session.GetString("Name");
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Userid"] = HttpContext.Session.GetInt32("Userid");
                var ExpToUpdate = db.tbl_Experince.Find(id);
                return View(ExpToUpdate);
            }
            else
            {
                return RedirectToAction("Login","Admin");
            }
        }
        [HttpPost]
        public IActionResult UpdateExperiance(Experince experiance)
        {
            db.tbl_Experince.Update(experiance);
            db.SaveChanges();
            return RedirectToAction("ShowExperiance");
        }
        //..............................................................Profile..................................................

        public IActionResult Profile()
        {
            if (HttpContext.Session.GetString("Flag") == "true")
            {
                ViewData["userName"] = HttpContext.Session.GetString("Name");
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Userid"] = HttpContext.Session.GetInt32("Userid");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }
        [HttpPost]
        public IActionResult Profile(ProfileVM profileVM)
        {
            if (ModelState.IsValid)
            {
                ViewData["userName"] = HttpContext.Session.GetString("Name");
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Userid"] = HttpContext.Session.GetInt32("Userid");

                string ImageName = profileVM.Image.FileName.ToString();
                Profile profile = new Profile();

                profile.Name = profileVM.Name;
                profile.Email = profileVM.Email;
                profile.Phone = profileVM.Phone;
                profile.Designation = profileVM.Designation;
                profile.Address = profileVM.Address;
                profile.Username = profileVM.Username;
                profile.Password = profileVM.Password;
                profile.Image = profileVM.Image.FileName.ToString();

                var folderPath = Path.Combine(env.WebRootPath, "images");
                var picturePath = Path.Combine(folderPath, ImageName);

                var FileToMove = new FileStream(picturePath, FileMode.Create);
                profileVM.Image.CopyTo(FileToMove);

                db.tbl_Profile.Add(profile);
               db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        //.............................................Add Project

        //...................................................////////////////////////////////

        public IActionResult Projects()
        {
            if (HttpContext.Session.GetString("Flag") == "true")
            {
                ViewData["userName"] = HttpContext.Session.GetString("Name");
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Userid"] = HttpContext.Session.GetInt32("Userid");
                ViewData["Vedio"] = HttpContext.Session.GetInt32("Vedio");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }

        }
        [HttpPost]
        public IActionResult Projects(ProjectsVM projectsVM)
        {
            if (ModelState.IsValid)
            {
                ViewData["userName"] = HttpContext.Session.GetString("Name");
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Userid"] = HttpContext.Session.GetInt32("Userid");
                ViewData["Vedio"] = HttpContext.Session.GetInt32("Vedio");

                Projects projects = new Projects();
               
                String VedioName = projectsVM.Vedio.FileName.ToString();
                projects.Name = projectsVM.Name;
                projects.Vedio = projectsVM.Vedio.FileName.ToString();

                var FolderPath = Path.Combine(env.WebRootPath, "vedios");
                var VedioPath = Path.Combine(FolderPath, VedioName);

                var FileToMove = new FileStream(VedioPath, FileMode.Create);
                projectsVM.Vedio.CopyTo(FileToMove);

                db.tbl_Projects.Add(projects);
                db.SaveChanges();
                return RedirectToAction("Index");

            }


            return View();

        }

        //.................................................../////////////////////////////////
        //......................................................Show Project

        public IActionResult ShowProject(int Id)
        {
            var ProjectToShow = db.tbl_Projects.Find(Id);
            ProjectsVM projectsVM = new ProjectsVM();

            projectsVM.Name = ProjectToShow.Name;
            projectsVM.OldVedio = ProjectToShow.Vedio;




            return View();

        }




        //...................................................................Login.................................................
        public IActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)

            {
                ViewData["userName"] = HttpContext.Session.GetString("Name");
                ViewData["Image"] = HttpContext.Session.GetString("Image");
                ViewData["Userid"] = HttpContext.Session.GetInt32("Userid");
                var LoggedInPerson = db.tbl_Profile.Where(opt => opt.Password == loginVM.Password && opt.Username == loginVM.Username).FirstOrDefault();
                if (LoggedInPerson != null)
                {
                    HttpContext.Session.SetInt32("Userid", LoggedInPerson.id);
                    HttpContext.Session.SetString("Name", LoggedInPerson.Name);
                    HttpContext.Session.SetString("Image", LoggedInPerson.Image);

                    HttpContext.Session.SetString("Flag", "true");
                    return RedirectToAction("Index");
                }
                ViewData["Errormessage"] = "Invalid Username and Password";
            }
            return View();
        }

        //..............................................................Logout..................................................
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
        //.....................................................................................................

        public IActionResult ShowProfile(int id)
        {
            var ProfiletoShow =db.tbl_Profile.Find(id);
            ProfileVM profileVM = new ProfileVM(); 

            profileVM.Name =ProfiletoShow.Name; 
            profileVM.Address =ProfiletoShow.Address;   
            profileVM.Password =ProfiletoShow.Password;
            profileVM.CPassword = ProfiletoShow.Password;
            profileVM.Username =ProfiletoShow.Username; 
            profileVM.Designation=ProfiletoShow.Designation;    
            profileVM.Email =ProfiletoShow.Email;   
            profileVM.Phone =ProfiletoShow.Phone;
            profileVM.OldImage = ProfiletoShow.Image;


             
            return View(profileVM); 
        }
    }
}






