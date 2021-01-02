// using System.Collections.Generic;
// using System.Linq;
// using InredningOnline.Models;

// namespace InredningOnline.ViewModels
// {
//     public class EditProjectViewModel
//     {
//         public Project Project { get; set; }
//         public Designer Designer { get; set; }
//         public Material Material { get; set; }

//         public IEnumerable<Project> Projects { get; set; }
//         public IEnumerable<Designer> Designers { get; set; }
//         public IEnumerable<Material> Materials { get; set; }
//         public IProjectRepo Repo { get; set; }

//         public decimal GetAverageCost()
//         {
//             if (this.Projects.ToList().Count > 0)
//                 return this.GetTotalCost() / this.Projects.ToList().Count;
//             else
//             {
//                 return -1;
//             }
//         }

//         public decimal GetTotalCost()
//         {
//             decimal total = 0;
//             foreach (var project in this.Projects)
//             {
//                 total += project.GetTotalCost();
//             }
//             return total;
//         }

//         public Project GetProjectById(int id)
//         {
//             return this.Projects.FirstOrDefault(p => p.Id == id);
//         }

//         public Designer GetDesignerById(int id)
//         {
//             return this.Designers.FirstOrDefault(d => d.Id == id);
//         }

//         public IEnumerable<Material> GetMaterialsByProject(int projectId)
//         {
//             return this.Materials.Where(m => m.ProjectId == projectId);
//         }

//         public Material GetMaterialById(int Id)
//         {
//             return this.Materials.FirstOrDefault(m => m.Id == Id);
//         }
//     }
// }