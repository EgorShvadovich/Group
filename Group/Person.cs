namespace Group
{
    

    internal class Person 
    {
        private string name;
        private int age;
        private string surname;
        private DateTime dateBirthday;
        private string address;
        private int phoneNumber;

        public Person()
        {
            name = "Andrey";
            age = 20;
            surname = "Alexeev";
            dateBirthday.AddMonths(2);
            dateBirthday.AddDays(23);
            dateBirthday.AddYears(2002);
            address = "T.Shevchenka 23";
            phoneNumber = 5553535;
        }
        /// <summary>
        /// Конструктор который позволяет поменять имя студенту
        /// </summary>
        /// <param name="name">Передача имени</param>
        public Person(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Конструктор который позволяет поменять имя и фамилию студенту
        /// </summary>
        /// <param name="name">Передача имени</param>
        /// <param name="surname">Передача фамилии</param>
        public Person(string surname, string name)
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
        public Person(string surname, string name, int age)
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
    }
}
