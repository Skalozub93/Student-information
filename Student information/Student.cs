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
        private int age;

        private DateTime date = new DateTime();
        private string[,,] adress;
        private long phoneNumber;

        public Student() { }
        
        public Student(string name)
        {
            this.name = name;
        }

        public Student(string name,string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public Student(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }


        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }
        public void SetAge(int age)
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



        public string GetName()
        {
            return this.name;
        }
        public string GetSurname()
        {
            return this.surname;
        }
        public int GetAge()
        {
            return this.age;
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
