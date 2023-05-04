using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketLaunchSim.Data
{
    internal class Constants
    {
        public const double GravConst = 6.6743E-11;
        public enum Controls { PITCH, AOA, THRUST, VELOCITY, VELOCITYH, VELOCITYV, ACCELERATION, ACCELERATIONH, ACCELERATIONV}
        public enum Readouts { START, ACCELERATION, ACCELERATIONH, ACCELERATIONV, VELOCITY, VELOCITYH, VELOCITYV, ALTITUDE, AOA}
        public enum Comparisons { IS, NOT, LESS, OVER}
        public enum BoolOperator { AND, OR, NOT, XOR}

    }
}
