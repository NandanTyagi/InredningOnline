using Microsoft.AspNetCore.Mvc;
using InredningOnline.Models;
using InredningOnline.ViewModels;

namespace InredningOnline.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly IProjectRepo _projectRepo;
        private readonly IUserRepo _userRepo;

        private readonly IMaterialRepo _materialRepo;

        public ProjectsController(IProjectRepo projectRepo, IUserRepo userRepo, IMaterialRepo materialRepo)
        {
            _projectRepo = projectRepo;
            _userRepo = userRepo;
            _materialRepo = materialRepo;
        }

        public IActionResult Index()
        {
            ProjectsViewModel projectsViewModel = new ProjectsViewModel();
            projectsViewModel.Projects = _projectRepo.AllProjects;
            projectsViewModel.Users = _userRepo.AllUsers;
            projectsViewModel.Materials = _materialRepo.AllMaterials;
            return View(projectsViewModel);
        }
    }
}
