using System.Collections.Generic;
using System.Linq;

namespace InredningOnline.Models
{
    public class Project
    {
        
        // Constructor
        // public Project(string name, User user, MockProjectRepo repo)
        // {
        //     Name = name;
        //     User = user;
        //     repo.AllProjects.Add(this);
        // }

        // Properties
        public string Name { get; set; }
        public User User { get; set; }
        public IEnumerable<Material> Materials { get; set; }
        // public List<Material> Materials = new List<Material>();

        // Methods
        // public void AddMaterial(Material material)
        // {
        //     Materials.Add(material);
        // }

        public decimal GetTotalCost()
        {
            decimal total = 0;

            foreach (var material in this.Materials)
            {
                total += material.Price * material.Amount;
            }

            return total;
        }
    }
}