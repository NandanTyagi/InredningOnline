using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using InredningOnline.Models;
using InredningOnline.ViewModels;

namespace InredningOnline.Controllers
{
    public class HomeController : Controller
    {
        private readonly MockProjectRepo _mockProjectRepo;
        private readonly MockUserRepo _mockUserRepo;

        public HomeController(MockProjectRepo mockProjectRepo, MockUserRepo mockUserRepo)
        {
            _mockProjectRepo = mockProjectRepo;
            _mockUserRepo = mockUserRepo;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.Projects = _mockProjectRepo.AllProjects;
            
            return View(homeViewModel);
        }

        // public IActionResult Privacy()
        // {
        //     return View();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
