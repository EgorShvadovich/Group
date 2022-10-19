using System.Collections;

namespace Group
{
    
    internal class Group : Student
    {
        static int countStudents = 12;
        ArrayList students = new ArrayList();
        string nameGroup = "bu111";
        string nameSpecalizationGroup = "designer";
        int numberSemester = 2;

        string[] names = { "alex", "andrey", "katya", "vitalik", "alyona", "vlad", "kirill", "vladimir", "egor", "sonya", "ira", "sergey" };
        string[] surnames = { "Shevchenko", "Vasilenko", "Ovcharenko", "Borisenko", "Tkachenko", "Fedorenko", "Jakovenko", "Pavlenko", "Ivashenko", "Sklyarenko", "Kravchenko", "Ponomarenko" };

        Random random = new Random();
        //Student raitingStudents = new Student();

        //------------CONSTRUCTORS------------
        /// <summary>
        /// Конструктор без параметров который инициализирует группу студентов.
        /// </summary>
        public Group() 
        {
            for (int i = 0; i < countStudents; i++)
            {
                students.Add(new Student());
                (students[i] as Student).Name = names[random.Next(0, 12)];
                (students[i] as Student).Surname = surnames[random.Next(0, 12)];
                (students[i] as Student).Age = random.Next(16, 50);
                (students[i] as Student).SetExam();
            }
        }
        /// <summary>
        /// Конструктор который позволяет изменить кол-во студентов в группе.
        /// <param name="x">Количество,которое хотите задать</param>
        /// </summary>
        public Group(int x)
        {
            countStudents = x;
        }
        /// <summary>
        /// Конструктор который позволяет скопировать с одной группы всех студентов в данную.
        /// <param name="g">Группа с которой будем копировать</param>
        /// </summary>
        public Group(Group g)
        {
            countStudents = g.GetCountStudents();
            this.students = g.students;
            this.nameGroup = g.nameGroup;
            this.nameSpecalizationGroup = g.nameSpecalizationGroup;
            this.numberSemester = g.numberSemester;
        }
        //------------SETTERS------------
        /// <summary>
        /// Этот метод меняет количество студентов.
        /// </summary>
        /// <param name="x">Количество,которое хотите задать</param>

        public void SetCountStudents(int x)
        {
            countStudents = x;
        }
        /// <summary>
        /// Этот метод меняет название группы.
        /// </summary>
        /// <param name="nameGroup">Задать название группы</param>
        public void SetNameGroup(string nameGroup)
        {
            this.nameGroup = nameGroup;
        }
        /// <summary>
        /// Этот метод меняет специализацию группы.
        /// </summary>
        /// <param name="nameSpecalizationGroup">Задать название специализации</param>
        public void SetNameSpecalizationGroup(string nameSpecalizationGroup)
        {
            this.nameSpecalizationGroup = nameSpecalizationGroup;
        }
        /// <summary>
        /// Этот метод меняет номер семестра.
        /// </summary>
        /// <param name="numberSemester">Задать номер семестра</param>
        public void SetNumberSemester(int numberSemester)
        {
            this.numberSemester = numberSemester;
        }
        //------------GETTERS------------
        /// <summary>
        /// Этот метод возвращает кол-во студентов.
        /// </summary>
        public int GetCountStudents()
        {
            return countStudents;
        }
        /// <summary>
        /// Этот метод возвращает кол-во студентов.
        /// </summary>
        public string GetNameGroup()
        {
            return nameGroup;
        }
        /// <summary>
        /// Этот метод возвращает название специализации группы.
        /// </summary>
        public string GetNameSpecalizationGroup()
        {
            return nameSpecalizationGroup;
        }
        /// <summary>
        /// Этот метод возвращает номер семестра группы.
        /// </summary>
        public int GetNumberSemester()
        {
            return numberSemester;
        }

        //------------METHODS------------
        /// <summary>
        /// Этот метод добавляет студента в группу.
        /// </summary>
        /// <param name="surname">Фамилия</param>
        /// <param name="name">Имя</param>
        /// <param name="age">Возраст</param>
        public void AddStudent(string surname, string name, int age)
        {
            students.Add(new Student());
            (students[students.Count] as Student).Name = names[random.Next(0, 12)];
            (students[students.Count] as Student).Surname = surnames[random.Next(0, 12)];
            (students[students.Count] as Student).Age = random.Next(16, 50);
            (students[students.Count] as Student).SetExam();
        }
        public void AddStudent()
        {
        }
        /// <summary>
        /// Этот метод редактирует студента в группе.
        /// </summary>
        /// <param name="surname">Фамилия</param>
        /// <param name="name">Имя</param>
        /// <param name="age">Возраст</param>
        /// <param name="x">Число которое выбирает студента для редактирования(по списку)</param>
        public void EditStudent(int x, string surname, string name, int age)
        {
            (students[x - 1] as Student).Name = name;
            (students[x - 1] as Student).Surname = surname;
            (students[x - 1] as Student).Age = age;
        }
        /// <summary>
        /// Этот метод редактирует группу.
        /// </summary>
        /// <param name="nameGroup">Имя группы</param>
        /// <param name="nameSpecalizationGroup">Имя специализации группы</param>
        public void EditGroup(string nameGroup, string nameSpecalizationGroup)
        {
            this.nameGroup = nameGroup;
            this.nameSpecalizationGroup = nameSpecalizationGroup;
        }
        /// <summary>
        /// Переброска одного студента с одной группы в другую группу(по списку).
        /// </summary>
        /// <param name="first">Передача первой группы откуда хотим перевести студента</param>
        /// <param name="second">То,собственно куда его переводим</param>
        /// <param name="x">Номер студента в 1 группе по списку</param>
        public void TransferenceStudent(int x, Group first, Group second)
        {
            second.students[x - 1] = first.students[x - 1];
        }
        //public void EliminationStudent()
        //{
        //    for (int i = 0; i < students.Count; i++)
        //    {
        //        ArrayList stud = new ArrayList();
        //        stud.Add(new Student());
        //        if (!(students[i] as Student).GetExam() == false)
        //        {
        //            students.RemoveAt(i);
        //        }
        //    }
        //}
        /// <summary>
        /// Отчисление самого слабого студента по оценкам.
        /// </summary>
        public void UnsuccessfulStudent()
        {
            int x = 12;
            int y = 0;
            int[] arrStud = new int[countStudents];
            for (int i = 0; i < arrStud.Length; i++)
            {
                for (int j = 0; j < (students[0] as Student).dzArr.Length; j++)
                {
                    arrStud[i] += (students[0] as Student).dzArr[j];
                }
                arrStud[i] /= (students[0] as Student).dzArr.Length;
            }
            for (int i = 0; i < arrStud.Length; i++)
            {
                if (arrStud[i] < x)
                {
                    x = arrStud[i];
                    y = i;
                }
            }
            students.RemoveAt(y);
        }
        public static bool operator ==(Group grp, Group grp1)
        {
            if (grp.students.Count == grp1.students.Count)
                return true;
            else return false;
        }
        public static bool operator !=(Group grp, Group grp1)
        {
            if (grp.students.Count != grp1.students.Count)
                return true;
            else return false;
        }
        //------------PRINT------------
        /// <summary>
        /// Показ группы в консоль.
        /// </summary>
        public override void Print()
        {
            Console.WriteLine("Nazvanie group: " + nameGroup);
            Console.WriteLine("Specialization group: " + nameSpecalizationGroup);
            for (int i = 0; i < countStudents; i++)
            {
                Console.WriteLine((i + 1) + ")  " + (students[i] as Student).Surname + "  " + (students[i] as Student).Name + "  " + (students[i] as Student).Age + " years");
            }
            Console.Write("\n");
        }
        /// <summary>
        /// Показ оценок студентов из группы в консоль.
        /// </summary>
        public void PrintRaitings()
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.Write((i + 1) + ")  ");
                for (int j = 0; j < (students[0] as Student).dzArr.Length; j++)
                {
                    Console.Write(" " + (students[i] as Student).dzArr[j]);
                }
                Console.Write("\n");
            }
        }
        /// <summary>
        /// Показ в консоль кто сдал жкзамен,кто - нет.
        /// </summary>
        public void PrintExams()
        {
            for (int i = 0; i < countStudents; i++)
            {
                Console.Write((i + 1) + ")  ");
                if ((students[i] as Student).GetExam() == false)
                    Console.Write("NE SDAL");
                else
                    Console.Write("SDAL");
                Console.Write("\n");
            }
        }
        public object this[int i]
        {
            get
            {
                return (students[i] as Student).Surname + "  " + (students[i] as Student).Name + "  " + (students[i] as Student).Age + " years";
            }
            set
            {
                students[i] = value;
            }
        }
    }
}
