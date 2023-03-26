namespace SanaFirstProject.Models
{
    public class User
    {
        protected string _name="";
        public string Name { get { return _name; } set { _name = value; } }
        public User(string name)
        {
            Name = name;
        }
        public User() {
            Name = "";
        }
    }
}
