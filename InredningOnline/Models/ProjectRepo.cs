using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InredningOnline.Models
{
    public class ProjectRepo : IProjectRepo
    {
        AppDbContext _appDbContext;

        public ProjectRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Project> AllProjects
        {
            get
            {
                return _appDbContext.Projects.Include(m => m.Materials).Include(u => u.User);
            }
        }

        public decimal GetAverageCost()
        {
            decimal total = 0;
            foreach (var project in _appDbContext.Projects)
            {
                total += project.GetTotalCost();
            }
            return total / _appDbContext.Projects.ToList().Count;

        }

        public decimal GetTotalCost()
        {
            decimal total = 0;
            foreach (var project in _appDbContext.Projects)
            {
                total += project.GetTotalCost();
            }
            return total;
        }

        public void SaveProject(Project project)
        {
            _appDbContext.Add(project);
            _appDbContext.SaveChanges();
        }
    }
}