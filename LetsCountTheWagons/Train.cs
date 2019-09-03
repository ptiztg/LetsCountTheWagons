using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsCountTheWagons
{
    class Train
    {
        private Wagon head = null;
        private Wagon tail = null;
        private int capacity = 0;


        public Wagon Head { get => head; set => head = value; }
        public Wagon Tail { get => tail; set => tail = value; }
        public int Capacity { get => capacity; set => capacity = value; }

        public Train()
        {
            Random random = new Random();
            Capacity = random.Next(1, 10000);

            for (int i = 0; i < Capacity; i++)
                Add(random.Next(1) == 0);
        }

        private void Add(bool isLightsOn)
        {
            if(head == null)
            {
                Head = new Wagon(isLightsOn);
                Tail = Head;
            }
            else
            {
                Wagon newWagon = new Wagon(isLightsOn, Tail, Head);
                Tail.NextWagon = newWagon;
                Head.PrevWagon = newWagon;
                Tail = newWagon;
            }
        }
    }
}
