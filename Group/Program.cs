namespace Group
{
    public static class Program
    {
        static void Main()
        {
            Group g = new Group();
            //Group g1 = new Group();
            g.Print();
            //g.PrintExams();
            //g1.PrintGroup();
            //g.EditStudent(3, "Shapovalov", "Artem", 23);
            //g.PrintGroup();
            //g.PrintRaitings();
            //g1.TransferenceStudent(3, g, g1);
            //g1.PrintGroup();
            //g.EliminationStudent();
            //g.UnsuccessfulStudent();
            g.AddStudent("Shvadovich", "Egor", 24);
            Aspirant c = new Aspirant();
            BadStudent b = new BadStudent();
            GoodStudent gs = new GoodStudent();
            g.AddStudent(c);
            g.AddStudent(b);
            g.AddStudent(gs);
            g.Print();
            //foreach (var item in g)
            //{
            //    Console.WriteLine(123);
            //}
            //Console.Write(g[1]);
        }
    }
}