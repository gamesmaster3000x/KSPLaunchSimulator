using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketLaunchSim.Data.SimScenario
{
    internal class SimulationScenarioParser
    {
        public enum SimSettings { TIMESTEP, PLANETMASS, PLANETRADIUS, STARTVELOCITY, STARTPOSITION };

        public double timestep;
        public double planetMass;
        public double planetRadius;
        public Vector264 startVelocity;
        public Vector264 startPosition;

        public List<Event> events;

        public SimulationScenarioParser(string path)
        {
            StreamReader reader = new(path);

            //Read the raw data from the file

            //Get each line of the file
            List<string> lines = new();
            while (!reader.EndOfStream)
            {
                lines.Add(reader.ReadLine() ?? "");
            }

            reader.Close();

            //Prepare the data for processing

            //Remove blank lines
            List<string> validLines = new List<string>();
            for (int i = 0; i < lines.Count; i++)
            {
                if (!string.IsNullOrEmpty(lines[i]))
                {
                    validLines.Add(lines[i]);
                }
            }
            lines = validLines;

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

            //For every line of the file
            bool preInit = true;
            Console.WriteLine("Parsing initial simulation conditions...");

            Condition condition;
            List<Instruction> instructions = new List<Instruction>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i][0].ToLower() == "event")
                {
                    Console.WriteLine("Registering new event...");
                    preInit = false;
                }

                if (preInit)
                {
                    PreInit(words[i]);
                }
                else
                {
                    
                }
            }
        }

        private void PreInit(string[] line)
        {
            switch (Enum.Parse(typeof(SimSettings), line[0].ToUpper()))
            {
                case SimSettings.TIMESTEP:
                    timestep = Convert.ToDouble(line[1]);
                    Console.WriteLine("Set Time Step to " + timestep);
                    break;
                case SimSettings.PLANETMASS:
                    planetMass = Convert.ToDouble(line[1]);
                    Console.WriteLine("Set Planet Mass to " + planetMass);
                    break;
                case SimSettings.PLANETRADIUS:
                    planetRadius = Convert.ToDouble(line[1]);
                    Console.WriteLine("Set Planet Radius to " + planetRadius);
                    break;
                case SimSettings.STARTVELOCITY:
                    startVelocity = new Vector264(Convert.ToDouble(line[1]), Convert.ToDouble(line[2]));
                    Console.WriteLine("Set Start Velocity to " + startVelocity);
                    break;
                case SimSettings.STARTPOSITION:
                    startPosition = new Vector264(Convert.ToDouble(line[1]), Convert.ToDouble(line[2]));
                    Console.WriteLine("Set Start Position to " + startPosition);
                    break;
                default:
                    break;
            }
        }
    }
}
