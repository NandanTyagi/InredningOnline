namespace InredningOnline.Tests
{
    public class Project
    {
        private string _name;
        

        public Project(string name)
        {
            Name = name;
        }

        public string Name { get => _name; set => _name = value; }
    }
}