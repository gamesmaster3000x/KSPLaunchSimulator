using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketLaunchSim.Data.Rocket
{
    internal class Stage
    {
        public double maxThrust;
        public double dryMass;
        public double fuelMass;
        public double fuelAtMaxThrust;
        public Stage(double maxThrust, double dryMass, double fuelMass, double fuelAtMaxThrust)
        {
            this.maxThrust = maxThrust;
            this.dryMass = dryMass;
            this.fuelMass = fuelMass;
            this.fuelAtMaxThrust = fuelAtMaxThrust;
        }
    }
}
