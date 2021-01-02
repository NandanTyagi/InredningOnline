using System.Collections.Generic;

namespace InredningOnline.Models
{
    public interface IProjectRepo
    {
        IEnumerable<Project> AllProjects { get;}
        decimal GetTotalCost();
        decimal GetAverageCost();
        Project GetProjectById(int Id);
        void SaveProject(Project project);
    }
}