using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Firstname = "Make ";
            person.Lastname = "Perusjäbä ";
            person.Age = 19;
            person.Address = "Puistokatu 8 ";
            person.Phonenumber = "123 ";
            Console.WriteLine(person.ToString());

            Teacher teacher = new Teacher("Jussi ", "Konsoli ", "D456 ");
            teacher.Address = "Piippukatu 1 ";
            teacher.Age = 40;
            teacher.Phonenumber = "456 ";
            Console.WriteLine(teacher.ToString());

            Student student = new Student("Pekka ", "Mikkonen ", "H0909 ");
            student.Address = "Ojakatu 13 ";
            student.Age = 24;
            student.Phonenumber = "789 ";
            Console.WriteLine(student.ToString());

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
