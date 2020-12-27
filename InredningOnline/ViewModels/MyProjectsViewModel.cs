using System.Collections.Generic;
using System.Linq;
using InredningOnline.Models;

namespace InredningOnline.ViewModels
{
    public class MyProjectsViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
        public IEnumerable<User> Designers { get; set; }
        public IEnumerable<Material> Materials { get; set; }
        public Project Project { get; set; }
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
        public decimal GetAverageCost(int userId)
        {
            if (this.Projects.ToList().Count > 0)
                return this.GetTotalCost(userId) / this.Projects.ToList().FindAll(p => p.UserId == userId).Count;
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
        public decimal GetTotalCost(int userId)
        {
            decimal total = 0;
            foreach (var project in this.Projects.Where(p => p.UserId == userId))
            {
                total += project.GetTotalCost();
            }
            return total;
        }
    }
}