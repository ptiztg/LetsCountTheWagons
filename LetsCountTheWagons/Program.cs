using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsCountTheWagons
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train();            
            Human.CountWagons(train.Head);

            Console.WriteLine("Human says:\r\n\tI counted  " + Human.Capacity + " wagons in the train.");
            Console.WriteLine("\r\nProgram says:\r\n\tI created the train with " + train.Capacity + " wagons in it.");
            Console.ReadKey();
        }
    }
}
