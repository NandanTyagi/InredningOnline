using System.Collections.Generic;
using System.Linq;

namespace InredningOnline.Models
{
    public class DesignerRepo : IDesignerRepo
    {
        AppDbContext _appDbContext;

        public DesignerRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Designer> AllDesigners
        {
            get
            {
                return _appDbContext.Designers;
            }
        }

        public Designer GetDesignerByName(string name)
        {
            return _appDbContext.Designers.FirstOrDefault(u => u.Name == name);
        }

        public void SaveDesigner(string name, string email, bool isAdmin)
        {
            var designer = new Designer()
            {

                Name = name,
                Email = email,
                IsAdmin = isAdmin
            };
            _appDbContext.Add(designer);
            _appDbContext.SaveChanges();
        }
    }
}