using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Razor.Language.Intermediate;

namespace InredningOnline.Models
{

    public class MockProjectRepo : IProjectRepo
    {
        MockMaterialRepo _mockMaterialRepo = new MockMaterialRepo();
        MockDesignerRepo _mockDesignerRepo = new MockDesignerRepo();
        public IEnumerable<Project> AllProjects
        {
            get
            {
                return new List<Project>
        {
            new Project{Id = 1, Name = "Project1", DesignerId =  _mockDesignerRepo.GetDesignerByName("Nandan").Id, Designer = _mockDesignerRepo.GetDesignerByName("Nandan"), Materials = _mockMaterialRepo.AllMaterials.ToList().FindAll(m => m.ProjectId == 1 )},
            new Project{Id = 2, Name = "Project2", DesignerId =  _mockDesignerRepo.GetDesignerByName("Hadis").Id, Designer = _mockDesignerRepo.GetDesignerByName("Hadis"), Materials = _mockMaterialRepo.AllMaterials.ToList().FindAll(m => m.ProjectId == 2 )},
            new Project{Id = 4, Name = "Project4", DesignerId =  _mockDesignerRepo.GetDesignerByName("Hadis").Id, Designer = _mockDesignerRepo.GetDesignerByName("Hadis"), Materials = _mockMaterialRepo.AllMaterials.ToList().FindAll(m => m.ProjectId == 4 )},
            new Project{Id = 3, Name = "Project3", DesignerId =  _mockDesignerRepo.GetDesignerByName("Ali").Id, Designer = _mockDesignerRepo.GetDesignerByName("Ali"), Materials = _mockMaterialRepo.AllMaterials.ToList().FindAll(m => m.ProjectId == 3 )}
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

            // if (this.Projects.ToList().Count > 0)
            //     return this.GetTotalCost() / this.Projects.ToList().Count;
            // else
            // {
            //     return -1;
            // }
        }

        public decimal GetAverageCost(int designerId)
        {
            if (this.AllProjects.ToList().Count > 0)
                return this.GetTotalCost(designerId) / this.AllProjects.ToList().FindAll(p => p.DesignerId == designerId).Count;
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
        
        public decimal GetTotalCost(int designerId)
        {
            decimal total = 0;
            foreach (var project in this.AllProjects.Where(p => p.DesignerId == designerId))
            {
                total += project.GetTotalCost();
            }
            return total;
        }

        Project IProjectRepo.GetProjectById(int Id)
        {
            throw new System.NotImplementedException();
        }

        void IProjectRepo.SaveProject(Project project)
        {
            throw new System.NotImplementedException();
        }
    }
}