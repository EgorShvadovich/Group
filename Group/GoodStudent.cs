namespace Group
{
    internal class GoodStudent : Student
    {
        string goodCharacter;

        public GoodStudent() : base()
        {
            goodCharacter = "good";
            Name = "Alyona";
            Surname = "Andreeva";
            Age = 26;
        }

        public string Character
        {
            get { return goodCharacter; }
            set { goodCharacter = value; }
        }
    }
}
