using System.Collections.Generic;

namespace InredningOnline.Models
{
    public interface IMaterialRepo
    {
        IEnumerable<Material> AllMaterials { get; }

        public IEnumerable<Material> GetMaterialsByProject(int projectId);

        public Material GetMaterialById(int Id);

        public void UpdateMaterial(Material material);

        void SaveMaterial(Material material);
    }

}