using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Razor.Language.Intermediate;

namespace InredningOnline.Models
{

    public class MockProjectRepo : IProjectRepo
    {
        MockMaterialRepo _mockMaterialRepo = new MockMaterialRepo();
        MockUserRepo _mockUserRepo = new MockUserRepo();
        public IEnumerable<Project> AllProjects
        {
            get
            {
                return new List<Project>
        {
            new Project{Id = 1, Name = "Project1", User = _mockUserRepo.GetUserByName("Nandan"), Materials = _mockMaterialRepo.AllMaterials.ToList().FindAll(m => m.ProjectId == 1 )},
            new Project{Id = 2, Name = "Project2", User = _mockUserRepo.GetUserByName("Hadis"), Materials = _mockMaterialRepo.AllMaterials.ToList().FindAll(m => m.ProjectId == 2 )},
            new Project{Id = 3, Name = "Project3", User = _mockUserRepo.GetUserByName("Ali"), Materials = _mockMaterialRepo.AllMaterials.ToList().FindAll(m => m.ProjectId == 3 )}
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

        void IProjectRepo.SaveProject(Project project)
        {
            throw new System.NotImplementedException();
        }
    }
}