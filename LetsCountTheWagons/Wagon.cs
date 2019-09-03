using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsCountTheWagons
{
    class Wagon
    {
        private bool isLightsOn;

        private Wagon prevWagon;
        private Wagon nextWagon;

        public bool IsLightsOn { get => isLightsOn; set => isLightsOn = value; }
        public Wagon PrevWagon { get => prevWagon; set => prevWagon = value; }
        public Wagon NextWagon { get => nextWagon; set => nextWagon = value; }

        public Wagon(bool isLightsOn)
        {
            IsLightsOn = isLightsOn;
            NextWagon = this;
            PrevWagon = this;
        }

        public Wagon(bool isLightsOn, Wagon prevWagon, Wagon nextWagon)
        {
            IsLightsOn = isLightsOn;
            NextWagon = nextWagon;
            PrevWagon = prevWagon;
        }
    }
}
