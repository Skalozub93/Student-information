using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_information
{
    internal class Student
    {
        private string name;
        private string surname;
        private DateTime age = new DateTime();

        private DateTime date = new DateTime();
        private string[,,] adress;
        private long phoneNumber;

        public Student() 
        {
            name = "Ivan";
            surname = "Ivanov";
            age = new DateTime(18);
        }
        
        public Student(string name, string surname, DateTime age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        // Setters

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }
        public void SetAge(DateTime age)
        {
            this.age = age;
        }
        public void SetData(DateTime data)
        {
            this.date = data;
        }
        public void SetAdress(string[,,] adress)
        {
            this.adress = adress;
        }
        public void SetPhoneNumber(long number)
        {
            this.phoneNumber = number;
        }

        //Getters

        public string GetName()
        {
            return this.name;
        }
        public string GetSurname()
        {
            return this.surname;
        }
        public DateTime GetAge()
        {
            return Convert.ToDateTime(this.age);
        }
        public DateTime GetData()
        {
            return this.date;
        }
        public string GetAdress()
        {
            return Convert.ToString(this.adress);
        }
        public long GetPhoneNumber()
        {
            return this.phoneNumber;
        }
    }
}
