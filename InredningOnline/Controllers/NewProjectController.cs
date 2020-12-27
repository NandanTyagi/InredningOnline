using System.Linq;
using InredningOnline.Models;
using InredningOnline.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace InredningOnline.Controllers
{
    public class NewProjectController : Controller
    {
        private readonly IProjectRepo _projectRepo;
        private readonly IUserRepo _userRepo;
        private readonly IMaterialRepo _materialRepo;

        public NewProjectController(IProjectRepo projectRepo, IUserRepo userRepo, IMaterialRepo materialRepo)
        {
            _projectRepo = projectRepo;
            _userRepo = userRepo;
            _materialRepo = materialRepo;
        }
        public IActionResult CreateProject()
        {
            NewProjectViewModel newProjectViewModel = new NewProjectViewModel();
            newProjectViewModel.Projects = _projectRepo.AllProjects;
            newProjectViewModel.Designers = _userRepo.AllDesigners;
            newProjectViewModel.Materials = _materialRepo.AllMaterials;
            return View(newProjectViewModel);
        }
        [HttpPost]
        public IActionResult CreateProject(Project project, Material material)
        {
            NewProjectViewModel newProjectViewModel = new NewProjectViewModel();
            newProjectViewModel.Projects = _projectRepo.AllProjects;
            newProjectViewModel.Designers = _userRepo.AllDesigners;
            newProjectViewModel.Materials = _materialRepo.AllMaterials;



            if (ModelState.IsValid)
            {
                _projectRepo.SaveProject(project);
                _materialRepo.SaveMaterial(material);
                return RedirectToAction("AddMaterial");
            }

            return View(project);
        }
        public IActionResult AddMaterial(Material material)
        {
            NewProjectViewModel newProjectViewModel = new NewProjectViewModel();
            newProjectViewModel.Projects = _projectRepo.AllProjects;
            newProjectViewModel.Designers = _userRepo.AllDesigners;
            newProjectViewModel.Materials = _materialRepo.AllMaterials;
            return View(newProjectViewModel);
        }
    }
}