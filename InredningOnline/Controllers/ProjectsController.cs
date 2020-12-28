using Microsoft.AspNetCore.Mvc;
using InredningOnline.Models;
using InredningOnline.ViewModels;
using Microsoft.AspNetCore.Authorization;

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
    }
}
