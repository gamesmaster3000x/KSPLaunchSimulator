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

        public Event[] events;

        public SimulationScenario(double timestep = 0.02f, double planetMass = 52915158000000000000000f, double planetRadius = 600000, Vector264? velocity = null)
        {
            this.timestep = timestep;
            this.planetMass = planetMass;
            this.planetRadius = planetRadius;
            this.velocity = velocity ?? Vector264.Zero;
        }

        //Yeah, I know, this should really be its own class.
        public SimulationScenario(string path)
        {
            StreamReader reader = new (path);
            
            //Get each line of the file
            List<string> lines = new ();
            while (!reader.EndOfStream) 
            {
                lines.Add(reader.ReadLine() ?? "");
            }

            reader.Close();

            //Split the line into its individual words
            string[][] words = new string[lines.Count][];
            for (int i = 0; i < lines.Count; i++)
            {
                words[i] = lines[i].Split(' ');
            }

            //Remove all the blank words generated above.
            for (int i = 0; i < words.Length; i++)
            {
                //I don't like this for several reasons, but it was the first stack overflow response, and it's more concise than my original idea.
                words[i] = words[i].Where(x => !string.IsNullOrEmpty(x)).ToArray();
            }

            //TODO: Combine as much of the above stuff as possible


        }
    }
}
