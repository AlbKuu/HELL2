using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Hissi
    {
        private readonly int minFloor = 1;
        private readonly int maxFloor = 5;
        private int floor=1;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value <= maxFloor) floor = value;
                else
                {
                    floor = maxFloor;
                    Console.WriteLine("Too high - set to max!");
                }
                if (value >= minFloor)floor = value;
                else
                {
                    floor = minFloor;
                    Console.WriteLine("Too low - set to min!");
                }
            }
        }
    }
}
