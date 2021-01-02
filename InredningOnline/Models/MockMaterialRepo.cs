using System.Collections.Generic;

namespace InredningOnline.Models
{

    public class MockMaterialRepo : IMaterialRepo
    {
        public IEnumerable<Material> AllMaterials
        {
            get
            {
                return new List<Material>
                {
                    new Material {Id = 1, ProjectId = 3,Name = "Chair1", Amount = 1, Price = 10, Details = "N/A"},
                    new Material {Id = 2, ProjectId = 1,Name = "Chair2", Amount = 1, Price = 20, Details = "N/A"},
                    new Material {Id = 3, ProjectId = 3,Name = "Chair3", Amount = 1, Price = 30, Details = "N/A"},
                    new Material {Id = 4, ProjectId = 2, Name = "Chair4", Amount = 1, Price = 79, Details = "N/A"},
                    new Material {Id = 5, ProjectId = 1,Name = "Chair5", Amount = 1, Price = 65, Details = "N/A"},
                    new Material {Id = 6, ProjectId = 2,Name = "Chair6", Amount = 10, Price = 22, Details = "N/A"},
                    new Material {Id = 7, ProjectId = 1,Name = "Chair7", Amount = 1, Price = 79, Details = "N/A"},
                    new Material {Id = 8, ProjectId = 2,Name = "Chair8", Amount = 1, Price = 65, Details = "N/A"},
                    new Material {Id = 9, ProjectId = 4,Name = "Chair9", Amount = 4, Price = 62, Details = "N/A"},
                    new Material {Id = 10, ProjectId = 4,Name = "Chair10", Amount = 10, Price = 64, Details = "N/A"},
                    new Material {Id = 11, ProjectId = 2,Name = "Chair9", Amount = 10, Price = 22, Details = "N/A"}
                };
            }
        }

        Material IMaterialRepo.GetMaterialById(int Id)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Material> IMaterialRepo.GetMaterialsByProject(int projectId)
        {
            throw new System.NotImplementedException();
        }

        void IMaterialRepo.SaveMaterial(Material material)
        {
            throw new System.NotImplementedException();
        }

        void IMaterialRepo.UpdateMaterial(Material material)
        {
            throw new System.NotImplementedException();
        }
    }
}