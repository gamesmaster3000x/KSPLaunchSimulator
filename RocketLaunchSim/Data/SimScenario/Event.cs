using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketLaunchSim.Data.SimScenario
{
    internal class Event
    {
        public readonly Condition condition;
        public readonly Instruction[] instructions;

        public Event(Condition condition, Instruction[] instructions)
        {
            this.condition = condition;
            this.instructions = instructions;
        }
    }
}
