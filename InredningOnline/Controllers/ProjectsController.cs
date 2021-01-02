using Microsoft.AspNetCore.Mvc;
using InredningOnline.Models;
using InredningOnline.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace InredningOnline.Controllers
{
    [Authorize]
    public class ProjectsController : Controller
    {
        private readonly IProjectRepo _projectRepo;
        private readonly IDesignerRepo _designerRepo;

        private readonly IMaterialRepo _materialRepo;

        public ProjectsController(IProjectRepo projectRepo, IDesignerRepo designerRepo, IMaterialRepo materialRepo)
        {
            _projectRepo = projectRepo;
            _designerRepo = designerRepo;
            _materialRepo = materialRepo;

        }

        public IActionResult Index()
        {
            ProjectsViewModel projectsViewModel = new ProjectsViewModel();
            projectsViewModel.Projects = _projectRepo.AllProjects;
            projectsViewModel.Designers = _designerRepo.AllDesigners;
            projectsViewModel.Materials = _materialRepo.AllMaterials;
            return View(projectsViewModel);
        }

        public IActionResult AllProjects()
        {
            ProjectsViewModel projectsViewModel = new ProjectsViewModel();
            projectsViewModel.Projects = _projectRepo.AllProjects;
            projectsViewModel.Designers = _designerRepo.AllDesigners;
            projectsViewModel.Materials = _materialRepo.AllMaterials;
            return View(projectsViewModel);
        }
        public IActionResult EditMaterial(int Id)
        {
            ProjectsViewModel projectsViewModel = new ProjectsViewModel();
            projectsViewModel.Repo = _projectRepo;
            projectsViewModel.Projects = _projectRepo.AllProjects;
            projectsViewModel.Designers = _designerRepo.AllDesigners;
            projectsViewModel.Materials = _materialRepo.AllMaterials;
            projectsViewModel.Project = _projectRepo.GetProjectById(_materialRepo.GetMaterialById(Id).ProjectId);
            projectsViewModel.Material = _materialRepo.GetMaterialById(Id);

            projectsViewModel.Designer = _designerRepo.GetDesignerById(projectsViewModel.Project.DesignerId);

            // if (projectsViewModel.Project == null || projectsViewModel.Designer == null)
            //     return NotFound();
            return View(projectsViewModel);
        }

        [HttpPost]
        public IActionResult EditMaterial(Material material)
        {
            ProjectsViewModel projectsViewModel = new ProjectsViewModel();
            projectsViewModel.Projects = _projectRepo.AllProjects;
            projectsViewModel.Designers = _designerRepo.AllDesigners;
            projectsViewModel.Materials = _materialRepo.AllMaterials;



            if (ModelState.IsValid)
            {
                _materialRepo.UpdateMaterial(material);
                return Redirect("/");
            }
            return View(projectsViewModel);
        }

        public IActionResult AddMaterial(int id)
        {
            ProjectsViewModel projectsViewModel = new ProjectsViewModel();
            projectsViewModel.Projects = _projectRepo.AllProjects;
            projectsViewModel.Designers = _designerRepo.AllDesigners;
            projectsViewModel.Materials = _materialRepo.AllMaterials;
            projectsViewModel.Project = _projectRepo.GetProjectById(id);
            // projectsViewModel.Project = _projectRepo.GetProjectById(_materialRepo.GetMaterialById(id).ProjectId);
            projectsViewModel.Material = _materialRepo.GetMaterialById(id);

            projectsViewModel.Designer = _designerRepo.GetDesignerById(projectsViewModel.Project.DesignerId);

            return View(projectsViewModel);
        }

        [HttpPost]
        public IActionResult AddMaterial(Material material)
        {
            ProjectsViewModel projectsViewModel = new ProjectsViewModel();
            projectsViewModel.Projects = _projectRepo.AllProjects;
            projectsViewModel.Designers = _designerRepo.AllDesigners;
            projectsViewModel.Materials = _materialRepo.AllMaterials;
                _materialRepo.SaveMaterial(material);
                return RedirectToAction("Index");

            // return RedirectToAction("Index");
        }




        public IActionResult CreateProject()
        {
            ProjectsViewModel projectsViewModel = new ProjectsViewModel();
            projectsViewModel.Projects = _projectRepo.AllProjects;
            projectsViewModel.Designers = _designerRepo.AllDesigners;
            projectsViewModel.Materials = _materialRepo.AllMaterials;
            return View(projectsViewModel);
        }
        [HttpPost]
        public IActionResult CreateProject(Project project, Material material)
        {
            ProjectsViewModel projectsViewModel = new ProjectsViewModel();
            projectsViewModel.Projects = _projectRepo.AllProjects;
            projectsViewModel.Designers = _designerRepo.AllDesigners;
            projectsViewModel.Materials = _materialRepo.AllMaterials;



            if (ModelState.IsValid)
            {
                _projectRepo.SaveProject(project);
                _materialRepo.SaveMaterial(material);
                return Redirect("/");
            }

            return View(projectsViewModel);
        }





        public IActionResult MyProjects()
        {
            ProjectsViewModel projectsViewModel = new ProjectsViewModel();
            projectsViewModel.Projects = _projectRepo.AllProjects;
            projectsViewModel.Designers = _designerRepo.AllDesigners;
            projectsViewModel.Materials = _materialRepo.AllMaterials;
            return View(projectsViewModel);
        }
    }
}
