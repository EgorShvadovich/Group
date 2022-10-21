namespace Group
{
    struct DateBirthday
    {
        int day;
        int month;
        int year;

        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
    }
    struct Address
    {
        string country;
        string city;
        string street;
        int house;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public int House
        {
            get { return house; }
            set { house = value; }
        }
    }

    internal class Person 
    {
        string name;
        int age;
        string surname;
        int phoneNumber;
        Address address;
        DateBirthday dateBirthday;

        public Person()
        {
            name = "Andrey";
            age = 20;
            surname = "Alexeev";
            dateBirthday.Month = 2;
            dateBirthday.Day = 23;
            dateBirthday.Year = 2002;
            address.Country = "Ukraine";
            address.City = "Odessa";
            address.Street = "Deribasovskaya";
            address.House = 22;
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
            dateBirthday.Year = year;
            dateBirthday.Month = month;
            dateBirthday.Day = day;
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
