using System.Collections;
using System.Collections.Generic;

namespace InredningOnline.Models
{
    public class MockProjectRepo
    {

        public List<Project> AllProjects = new List<Project>();

        public List<Project> GetProjectsList(User user)
        {
            throw new System.NotImplementedException();
        }

        public decimal GetAverageCost()
        {
            throw new System.NotImplementedException();
        }

        public decimal GetTotalCost()
        {
            throw new System.NotImplementedException();
        }
    }
}