using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dem04
{
    class Program
    {
        static void Main(string[] args)
        {
            car car = new car();
            car.Speed = 300;
            Console.WriteLine("car speed is " + car.Speed);
            Console.ReadLine();
        }
    }
}
