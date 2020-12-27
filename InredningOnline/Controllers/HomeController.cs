using InredningOnline.Models;
using InredningOnline.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace InredningOnline.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProjectRepo _projectRepo;
        private readonly IUserRepo _userRepo;
        private readonly IMaterialRepo _materialRepo;

        public HomeController(IProjectRepo projectRepo, IUserRepo userRepo, IMaterialRepo materialRepo)
        {
            _projectRepo = projectRepo;
            _userRepo = userRepo;
            _materialRepo = materialRepo;
        }
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.Projects = _projectRepo.AllProjects;
            homeViewModel.Users = _userRepo.AllUsers;
            homeViewModel.Materials = _materialRepo.AllMaterials;
            return View(homeViewModel);
        }
    }
}
