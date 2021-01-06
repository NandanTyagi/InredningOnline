using System.Collections.Generic;
using System.Linq;

namespace InredningOnline.Models
{
    public class MaterialRepo : IMaterialRepo
    {
        AppDbContext _appDbContext;

        public MaterialRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Material> AllMaterials
        {
            get
            {
                return _appDbContext.Materials;
            }
        }

        public void SaveMaterial(Material material)
        {
            _appDbContext.Materials.Add(material);
            _appDbContext.SaveChanges();
        }
        public void UpdateMaterial(Material material)
        {
            
            _appDbContext.Materials.FirstOrDefault(m => m.Id == material.Id).Name = material.Name;
            _appDbContext.Materials.FirstOrDefault(m => m.Id == material.Id).Supplier = material.Supplier;
            _appDbContext.Materials.FirstOrDefault(m => m.Id == material.Id).Amount = material.Amount;
            _appDbContext.Materials.FirstOrDefault(m => m.Id == material.Id).Price = material.Price;
            _appDbContext.Materials.FirstOrDefault(m => m.Id == material.Id).Details = material.Details;
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Material> GetMaterialsByProject(int projectId)
        {
            return this.AllMaterials.Where(m => m.ProjectId == projectId);
        }
        public Material GetMaterialById(int Id)
        {
            return this.AllMaterials.FirstOrDefault(m => m.Id == Id);
        }
    }
}