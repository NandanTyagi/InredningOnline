using System.Collections.Generic;

namespace InredningOnline.Models
{
    public interface IMaterialRepo
    {
        IEnumerable<Material> AllMaterials { get; }
    }
}