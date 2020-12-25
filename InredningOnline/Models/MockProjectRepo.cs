using System.Collections;
using System.Collections.Generic;

namespace InredningOnline.Models
{
    public class MockProjectRepo
    {

        public List<Project> AllProjects = new List<Project>();

        // Get a list of a secific users projects
        public List<Project> GetProjectsByUser(User user)
        {
            var userProjects = this.AllProjects.FindAll(p => p.User == user);

            return userProjects;
        }

        public decimal GetAverageCost()
        {
            if (this.AllProjects.Count > 0)
                return this.GetTotalCost() / this.AllProjects.Count;
            else
            {
                return -1;
            }
        }

        public decimal GetTotalCost()
        {
            decimal total = 0;

            foreach (var project in this.AllProjects)
            {
                total += project.GetTotalCost();
            }

            return total;
        }
    }
}