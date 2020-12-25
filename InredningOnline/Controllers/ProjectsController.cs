using Microsoft.AspNetCore.Mvc;
using InredningOnline.Models;
using InredningOnline.ViewModels;

namespace InredningOnline.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly IProjectRepo _projectRepo;
        private readonly IUserRepo _userRepo;

        public ProjectsController(IProjectRepo projectRepo, IUserRepo userRepo)
        {
            _projectRepo = projectRepo;
            _userRepo = userRepo;
        }

        public IActionResult Index()
        {
            ProjectsViewModel projectsViewModel = new ProjectsViewModel();
            projectsViewModel.Projects = _projectRepo.AllProjects;
            projectsViewModel.Users = _userRepo.AllUsers;
            return View(projectsViewModel);
        }
    }
}
