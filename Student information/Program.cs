using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Student_information
{
    internal class Program
    {
        static void Main()
        {
            Student v = new Student();

            v.SetName("Vlad");
            v.SetSurname("Skalozub");
            var date1 = new DateTime(2003,12,22,3,0,0);
            v.SetAge(date1);

            Console.WriteLine(v.GetName());
            Console.WriteLine(v.GetSurname());
            Console.WriteLine(v.GetAge());
        }
    }
}
