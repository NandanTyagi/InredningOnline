using System.Collections.Generic;

namespace InredningOnline.Models
{
    public class Project
    {

        public Project(string name, User user, MockProjectRepo repo)
        {
            Name = name;
            User = user;
            repo.AllProjects.Add(this);
        }

        public string Name { get; set; }
        public User User { get; set; }
        public List<Material> Materials = new List<Material>();

        public decimal GetTotalCost()
        {
            throw new System.NotImplementedException();
        }
    }
}