namespace Group
{
    internal class BadStudent : Student
    {
        string badCharacter;

        public BadStudent() : base()
        {
            badCharacter = "bad";
            Name = "valya";
            Surname = "Alexeeva";
            Age = 26;
        }

        public string BadCharacter
        {
            get { return badCharacter; }
            set { badCharacter = value; }
        }
    }
}
