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
            v.SetAge(18);

            Console.WriteLine(v.GetName());
            Console.WriteLine(v.GetSurname());
            Console.WriteLine(v.GetAge());
        }
    }
}
