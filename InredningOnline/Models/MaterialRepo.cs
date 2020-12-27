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
    }
}