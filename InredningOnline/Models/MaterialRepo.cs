using System.Collections.Generic;

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
    }
}