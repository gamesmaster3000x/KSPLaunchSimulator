namespace RocketLaunchSim.Data.SimScenario
{
    internal class Condition
    {
        public enum Readouts { START, ACCELERATION, ACCELERATIONH, ACCELERATIONV, VELOCITY, VELOCITYH, VELOCITYV, ALTITUDE, AOA }

        public readonly Readouts readout;
        public readonly double value;
    }
}
