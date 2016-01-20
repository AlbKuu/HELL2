using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Tehtävänäsi on ohjelmoida Dynamon hissin kerroksen ohjaukseen liittyvä säädin. 
             Toteutetun ohjelman tulee pystyä kysymään käyttäjältä haluttu kerros ja siirtämään hissi haluttuun kerrokseen 
             (tässä tapauksessa ohjelma kertoo käyttäjälle missä kerroksessa hissi on). 
             Muista, että Dynamon hissi voi olla vain kerroksissa 1-5. 
             Käytä Hissi-luokassa get- ja set-aksessoreita suojamaan olion tila.

            Esimerkkitoiminta: 
            Elevator is now in floor: 1
            Give a new floor number(1 - 5) > 2
            Elevator is now in floor: 2
            Give a new floor number(1 - 5) > 3
            Elevator is now in floor: 3
            Give a new floor number(1 - 5) > 5
            Elevator is now in floor: 5
            Give a new floor number(1 - 5) > -1
            Floor is too small!
            Elevator is now in floor: 5
            Give a new floor number(1 - 5) > 6
            Floor is too big!
            Elevator is now in floor: 5
            Give a new floor number(1 - 5) > 2
            Elevator is now in floor: 2

    // ask number from the user (read one line)
    Console.Write("Give a number > ");
    string line = Console.ReadLine();
    // try to read number from the given line
    int number;
    bool result = int.TryParse(line, out number);
    // number (integer) was given correctly, use it..
    if (result) {
        Console.WriteLine("Number was " + number);
    }

            do
{
   statement(s);

}while( condition );
            */
            Hissi hissi = new Hissi();
            Console.WriteLine("Welcome to the elevator! ");
            int number;
            do
            {
                Console.WriteLine("Elevator is now in floor " + hissi.Floor);
                Console.WriteLine("Give a new floor number(1 - 5) (Press enter to exit the elevator) ");
                string line = Console.ReadLine();
                bool result = int.TryParse(line, out number);
                if (result)
                {
                    Console.WriteLine("Number was " + number);
                    hissi.Floor = number;
                    Console.WriteLine("Elevator is now in floor " + hissi.Floor);
                }
                if (number == 0)
                {
                    Console.WriteLine("Bye bye! ");
                }
            } while (number != 0);
            Console.ReadLine();
        }
    }
}
