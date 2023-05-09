using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RocketLaunchSim.Data.SimScenario
{
    internal class SimulationScenario
    {
        public readonly double timestep;
        public readonly double planetMass;
        public readonly double planetRadius;
        public Vector264 velocity;
        public Vector264 position;

        public Event[] events;

        public SimulationScenario(double timestep = 0.02f, double planetMass = 52915158000000000000000f, double planetRadius = 600000, Vector264? velocity = null)
        {
            this.timestep = timestep;
            this.planetMass = planetMass;
            this.planetRadius = planetRadius;
            this.velocity = velocity ?? Vector264.Zero;
            this.position = new Vector264(0, planetRadius);
        }
    }
}
