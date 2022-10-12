namespace Group
{
    internal class Student
    {
        private string name;
        private int age;
        private string surname;

        private DateTime dateBirthday;

        private string address;
        private bool exam;
        private int phoneNumber;

        public int[] dzArr = new int[10];

        Random random = new Random();

        //------------CONSTRUCTORS------------
        /// <summary>
        /// Конструктор без параметров который рандомным образом заполняет успеваемость студента.
        /// </summary>
        public Student()
        {
            for (int i = 0; i < dzArr.Length; i++)
            {
                dzArr[i] = random.Next(2, 12);
            }
        }
        /// <summary>
        /// Конструктор который позволяет поменять имя студенту
        /// </summary>
        /// <param name="name">Передача имени</param>
        public Student(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Конструктор который позволяет поменять имя и фамилию студенту
        /// </summary>
        /// <param name="name">Передача имени</param>
        /// <param name="surname">Передача фамилии</param>
        public Student(string surname, string name)
        {
            this.name = name;
            this.surname = surname;
        }
        /// <summary>
        /// Конструктор который позволяет поменять имя и фамилию и возраст студенту
        /// </summary>
        /// <param name="name">Передача имени</param>
        /// <param name="surname">Передача фамилии</param>
        /// <param name="age">Передача возраста</param>
        public Student(string surname, string name, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        //------------SETTERS------------
        /// <summary>
        /// Метод который позволяет поменять имя студенту
        /// </summary>
        /// <param name="name">Передача имени</param>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        /// <summary>
        /// Метод который позволяет поменять фамилию студенту
        /// </summary>
        /// <param name="surname">Передача фамилии</param>
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        /// <summary>
        /// Метод который позволяет поменять возраст студенту
        /// </summary>
        /// <param name="age">Передача возраста</param>
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        /// <summary>
        /// Метод который позволяет поменять дату рождения студенту
        /// </summary>
        /// <param name="year">Передача года</param>
        /// <param name="month">Передача месяца</param>
        /// <param name="day">Передача дня</param>
        public void SetBirthday(int year, int month, int day)
        {
            dateBirthday = new DateTime(year, month, day);
        }
        /// <summary>
        /// Метод который позволяет поменять адрес студенту
        /// </summary>
        /// <param name="adress">Передача адреса</param>
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        /// <summary>
        /// Метод который позволяет поменять телефонный номер студенту
        /// </summary>
        /// <param name="phonenumber">Передача номера</param>
        public int Phonenumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

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
            if (stud.age == stud1.age && stud.name == stud1.name && stud.surname == stud1.surname)
                return true;
            else return false;
        }
        public static bool operator !=(Student stud, Student stud1)
        {
            if (stud.age != stud1.age && stud.name != stud1.name && stud.surname != stud1.surname)
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
    }
}
