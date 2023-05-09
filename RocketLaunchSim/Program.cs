using System.Net.Mail;
using System.Net.Security;
using System.Numerics;
using RocketLaunchSim.Data.Rocket;
using RocketLaunchSim.Data.SimScenario;

namespace RocketLaunchSim
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(C) RedFoxIndustries RocketLaunchSim [0.0.1]\n");

            Rocket rocket = new(new Stage[]{ new Stage(1000000f, 13000f, 70000f, 323.72f)}); //A big kerbodyne tank with a vector engine.

            Console.WriteLine("Enter the name of the file to load:");

            new SimulationScenarioParser(Console.ReadLine());
        }
    }
}