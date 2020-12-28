using Microsoft.AspNetCore.Mvc;
using InredningOnline.Models;
using InredningOnline.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace InredningOnline.Controllers
{
    [Authorize]
    public class MyProjectsController : Controller
    {
        private readonly IProjectRepo _projectRepo;
        private readonly IDesignerRepo _designerRepo;

        private readonly IMaterialRepo _materialRepo;

        public MyProjectsController(IProjectRepo projectRepo, IDesignerRepo designerRepo, IMaterialRepo materialRepo)
        {
            _projectRepo = projectRepo;
            _designerRepo = designerRepo;
            _materialRepo = materialRepo;
        }

        public IActionResult Index()
        {
            MyProjectsViewModel myProjectsViewModel = new MyProjectsViewModel();
            myProjectsViewModel.Projects = _projectRepo.AllProjects;
            myProjectsViewModel.Designers = _designerRepo.AllDesigners;
            myProjectsViewModel.Materials = _materialRepo.AllMaterials;
            return View(myProjectsViewModel);
        }
    }
}
