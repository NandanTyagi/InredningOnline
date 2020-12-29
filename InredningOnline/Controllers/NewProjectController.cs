using System.Linq;
using InredningOnline.Models;
using InredningOnline.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InredningOnline.Controllers
{
    [Authorize]
    public class NewProjectController : Controller
    {
        private readonly IProjectRepo _projectRepo;
        private readonly IDesignerRepo _designerRepo;
        private readonly IMaterialRepo _materialRepo;

        public NewProjectController(IProjectRepo projectRepo, IDesignerRepo designerRepo, IMaterialRepo materialRepo)
        {
            _projectRepo = projectRepo;
            _designerRepo = designerRepo;
            _materialRepo = materialRepo;
        }
        public IActionResult CreateProject()
        {
            NewProjectViewModel newProjectViewModel = new NewProjectViewModel();
            newProjectViewModel.Projects = _projectRepo.AllProjects;
            newProjectViewModel.Designers = _designerRepo.AllDesigners;
            newProjectViewModel.Materials = _materialRepo.AllMaterials;
            return View(newProjectViewModel);
        }
        [HttpPost]
        public IActionResult CreateProject(Project project, Material material)
        {
            NewProjectViewModel newProjectViewModel = new NewProjectViewModel();
            newProjectViewModel.Projects = _projectRepo.AllProjects;
            newProjectViewModel.Designers = _designerRepo.AllDesigners;
            newProjectViewModel.Materials = _materialRepo.AllMaterials;



            if (ModelState.IsValid)
            {
                _projectRepo.SaveProject(project);
                _materialRepo.SaveMaterial(material);
                return RedirectToAction("AddMaterial");
            }

            return View(newProjectViewModel);
        }
        public IActionResult AddMaterial(Material material)
        {
            NewProjectViewModel newProjectViewModel = new NewProjectViewModel();
            newProjectViewModel.Projects = _projectRepo.AllProjects;
            newProjectViewModel.Designers = _designerRepo.AllDesigners;
            newProjectViewModel.Materials = _materialRepo.AllMaterials;
            return View(newProjectViewModel);
        }
    }
}