using System.Collections.Generic;
using InredningOnline.Models;

namespace InredningOnline.ViewModels
{
    public class HomeViewModel
    {
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
    }
}