using System.Collections.Generic;
using System.Linq;
using InredningOnline.Models;

namespace InredningOnline.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<Material> Materials { get; set; }

        public decimal GetAverageCost()
        {
            if (this.Projects.ToList().Count > 0)
                return this.GetTotalCost() / this.Projects.ToList().Count;
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
    }
}