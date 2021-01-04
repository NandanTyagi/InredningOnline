using System.Collections.Generic;
using System.Linq;
using InredningOnline.Models;

namespace InredningOnline.ViewModels
{
    public class ProjectsViewModel

    {
        public IEnumerable<Project> Projects { get; set; }
        public IEnumerable<Designer> Designers { get; set; }
        public IEnumerable<Material> Materials { get; set; }
        public IProjectRepo Repo { get; set; }
        public Project Project { get; set; }
        public Designer Designer { get; set; }
        public Material Material { get; set; }

        public decimal GetAverageCost()
        {
            if (this.Projects.ToList().Count > 0)
                return this.GetTotalCost() / this.Projects.ToList().Count;
            else
            {
                return -1;
            }
        }

        public decimal GetAverageCost(int designerId)
        {
            if (this.Projects.ToList().Count > 0)
                return this.GetTotalCost(designerId) / this.Projects.ToList().FindAll(p => p.DesignerId == designerId).Count;
            else
            {
                return -1;
            }
        }

        public decimal GetTotalCost()
        {
            decimal total = 0;
            foreach (var project in this.Projects)
            {
                total += project.GetTotalCost();
            }
            return total;
        }

        public decimal GetTotalCost(int designerId)
        {
            decimal total = 0;
            foreach (var project in this.Projects.Where(p => p.DesignerId == designerId))
            {
                total += project.GetTotalCost();
            }
            return total;
        }

        public Designer GetDesignerById(int id)
        {
            return this.Designers.FirstOrDefault(d => d.Id == id);
        }
    }
}