using InredningOnline.Models;
using InredningOnline.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace InredningOnline.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProjectRepo _projectRepo;
        private readonly IDesignerRepo _designerRepo;
        private readonly IMaterialRepo _materialRepo;

        public HomeController(IProjectRepo projectRepo, IDesignerRepo designerRepo, IMaterialRepo materialRepo)
        {
            _projectRepo = projectRepo;
            _designerRepo = designerRepo;
            _materialRepo = materialRepo;
        }
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.Projects = _projectRepo.AllProjects;
            homeViewModel.Designers = _designerRepo.AllDesigners;
            homeViewModel.Materials = _materialRepo.AllMaterials;
            return View(homeViewModel);
        }
    }
}
