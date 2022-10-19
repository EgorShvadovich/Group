namespace Group
{
    internal class Aspirant : Student
    {
        string theme;
        public Aspirant() : base()
        {
            theme = "Java";
        }
        public Aspirant(string theme)
        {
            this.theme = theme; 
        }
        public string Theme
        { 
            get { return theme; }
            set { theme = value; }
        }
    }
}
