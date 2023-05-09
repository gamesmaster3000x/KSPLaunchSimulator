using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RocketLaunchSim.Data.Constants;

namespace RocketLaunchSim.Data.SimScenario
{
    internal class Instruction
    {
        public enum Controls { PITCH, AOA, THRUST, VELOCITY, VELOCITYH, VELOCITYV, ACCELERATION, ACCELERATIONH, ACCELERATIONV }

        public readonly Controls control;
        public readonly double setPoint;
    }
}
