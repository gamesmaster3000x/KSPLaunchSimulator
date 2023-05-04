using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketLaunchSim.Data.Rocket
{
    internal class Rocket
    {
        public Stage[] stages;

        public Rocket(Stage[] stages)
        {
            this.stages = stages;
        }
    }
}
