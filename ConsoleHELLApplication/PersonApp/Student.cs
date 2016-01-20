using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Student : Person
    {
        public string Id { get; set; }
        public Student()
        {

        }
        public Student(string firstname, string lastname, string id) 
            : base (firstname, lastname)
        {
            Id = id;
        }

        public void StudentMethod()
        {
            Console.WriteLine("Student does something... ");
        }
        public override string ToString()
        {
            return base.ToString() + " " + Id;
        }
    }
}
