using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dem04
{
    class car
    {
        //max speed
        private readonly int maxSpeed = 200;
        //member field
        private int speed;
        //property
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value <= maxSpeed) speed = value;
                else
                {
                    Console.WriteLine("Too much speed - set to max!");
                    speed = maxSpeed;
                }  
            }
        }
    }
}
