using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Razor.Language.Intermediate;

namespace InredningOnline.Models
{

    public class MockProjectRepo : IProjectRepo
    {
        MockUserRepo _mockUserRepo = new MockUserRepo();

        // public List<Project> AllProjects = new List<Project>();

        // // Get a list of a secific users projects
        // public List<Project> GetProjectsByUser(User user)
        // {
        //     var userProjects = this.AllProjects.FindAll(p => p.User == user);

        //     return userProjects;
        // }

        // public decimal GetAverageCost()
        // {
        //     if (this.AllProjects.Count > 0)
        //         return this.GetTotalCost() / this.AllProjects.Count;
        //     else
        //     {
        //         return -1;
        //     }
        // }

        // public decimal GetTotalCost()
        // {
        //     decimal total = 0;

        //     foreach (var project in this.AllProjects)
        //     {
        //         total += project.GetTotalCost();
        //     }

        //     return total;
        // }
        public IEnumerable<Project> AllProjects
        {
            get
            {
                return new List<Project>
        {
            new Project{Name = "Project1", User = _mockUserRepo.GetUserByName("Nandan"), Materials = new List<Material>
            {
                new Material {Name = "Chair1", Amount = 1, Price = 10, Details = "N/A"},
                new Material {Name = "Chair2", Amount = 1, Price = 20, Details = "N/A"},
                new Material {Name = "Chair3", Amount = 1, Price = 30, Details = "N/A"}
            }},
            new Project{Name = "Project2", User = _mockUserRepo.GetUserByName("Hadis"), Materials= new List<Material>
            {
                new Material {Name = "Chair4", Amount = 1, Price = 40, Details = "N/A"},
                new Material {Name = "Chair5", Amount = 1, Price = 50, Details = "N/A"},
                new Material {Name = "Chair6", Amount = 1, Price = 60, Details = "N/A"}
            }},
            new Project{Name = "Project3", User = _mockUserRepo.GetUserByName("Ali"), Materials= new List<Material>
            {
                new Material {Name = "Chair4", Amount = 1, Price = 79, Details = "N/A"},
                new Material {Name = "Chair5", Amount = 1, Price = 64, Details = "N/A"},
                new Material {Name = "Chair6", Amount = 10, Price = 22, Details = "N/A"}
            }}
        };
            }
        }

        public decimal GetAverageCost()
        {
            if (this.AllProjects.ToList().Count > 0)
                return this.GetTotalCost() / this.AllProjects.ToList().Count;
            else
            {
                return -1;
            }
        }

        public decimal GetTotalCost()
        {
            decimal total = 0;
            foreach (var project in this.AllProjects)
            {
                total += project.GetTotalCost();
            }
            return total;
        }
    }
}