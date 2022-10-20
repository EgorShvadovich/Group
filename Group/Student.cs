namespace Group
{
    
     class Student : Person, ICloneable, IComparable<Student>
    {
        private bool exam;
        private static int x = 10;
        public int[] dzArr = new int[x];

        Random random = new Random();

        //------------CONSTRUCTORS------------
        /// <summary>
        /// Конструктор без параметров который рандомным образом заполняет успеваемость студента.
        /// </summary>
        public Student() : base() 
        {
            exam = true;
            for (int i = 0; i < dzArr.Length; i++)
            {
                dzArr[i] = random.Next(2, 12);
            }
        }
        public Student(string surname, string name, int age) : base (surname,name,age){}
        /// <summary>
        /// Метод который позволяет рандомным образом определить сдал студент экзамен или нет
        /// </summary>
        public void SetExam()
        {
            if (random.Next(0, 2) == 0)
                exam = false;
            else exam = true;

        }

        //------------GETTERS------------
        /// <summary>
        /// Метод который возвращает имя студента
        /// </summary>

        public bool GetExam()
        {
            return exam;
        }

        public double GetSumDz()
        {
            return dzArr.Sum();
        }

        public static bool operator ==(Student stud, Student stud1)
        {
            if (stud.Age == stud1.Age && stud.Name == stud1.Name && stud.Surname == stud1.Surname)
                return true;
            else return false;
        }
        public static bool operator !=(Student stud, Student stud1)
        {
            if (stud.Age != stud1.Age && stud.Name != stud1.Name && stud.Surname != stud1.Surname)
                return true;
            else return false;
        }
        public static double operator >(Student stud, Student stud1)
        {
            if (stud.GetSumDz() > stud1.GetSumDz())
                return stud.GetSumDz();
            else return stud1.GetSumDz();
        }
        public static double operator <(Student stud, Student stud1)
        {
            if (stud.GetSumDz() < stud1.GetSumDz())
                return stud.GetSumDz();
            else return stud1.GetSumDz();
        }
        public object Clone()
        {
            return (this.Name, this.Surname, this.Age,this.Phonenumber, this.dzArr, this.exam);
        }
        public int CompareTo(Student stud)
        {
            if (this.GetSumDz() > stud.GetSumDz()) return 1;
            if (this.GetSumDz() < stud.GetSumDz()) return -1;
            return 0;
        }
        public virtual void Print()
        {
            Console.WriteLine(Surname + "  " + Name + "  " + Age + " years." + "Sdal exam?" + exam + "\n");
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(dzArr[i] + " ocenka za " + (i+1) +" dz");
            }
        }
        
    }
}
