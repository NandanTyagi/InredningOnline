using Microsoft.AspNetCore.Mvc;
using InredningOnline.Models;
using InredningOnline.ViewModels;

namespace InredningOnline.Controllers
{
    public class MyProjectsController : Controller
    {
        private readonly IProjectRepo _projectRepo;
        private readonly IUserRepo _userRepo;

        private readonly IMaterialRepo _materialRepo;

        public MyProjectsController(IProjectRepo projectRepo, IUserRepo userRepo, IMaterialRepo materialRepo)
        {
            _projectRepo = projectRepo;
            _userRepo = userRepo;
            _materialRepo = materialRepo;
        }

        public IActionResult Index()
        {
            MyProjectsViewModel myProjectsViewModel = new MyProjectsViewModel();
            myProjectsViewModel.Projects = _projectRepo.AllProjects;
            myProjectsViewModel.Designers = _userRepo.AllDesigners;
            myProjectsViewModel.Materials = _materialRepo.AllMaterials;
            return View(myProjectsViewModel);
        }
    }
}
