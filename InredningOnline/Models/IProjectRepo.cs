using System.Collections.Generic;

namespace InredningOnline.Models
{
    public interface IProjectRepo
    {
        IEnumerable<Project> AllProjects { get;}
        decimal GetTotalCost();
        decimal GetAverageCost();
        Project GetProjectById(int Id);
        void UpdateProject(Project oldProject, Project newProject);
        void SaveProject(Project project);
    }
}