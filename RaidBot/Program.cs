

using RaidBot.Engine.Bot;
using RaidBot.Engine.Daemon;
using System;
using System.Net;
using System.Threading.Tasks;

namespace RaidBot
{
    class MainClass
    {
        static bool dready = false;
        private static Daemon d;
        public static void Main(string[] args)
        {
            d = new Daemon();
            d.Ready += D_Ready;
            while (true)
            {
                if (dready)
                {
                    Console.WriteLine("Launching ...");
                    Brain brain = new Brain(new BotConfig("acorbeau1", "Asyade123581321"), d);
                    brain.UpdateClient(new Common.Network.Client.Client(IPAddress.Parse("34.252.21.81"), 5555, new Common.Default.Loging.Logger()));
                }
                Console.ReadLine();
            }
        }

        private static void D_Ready(object sender, EventArgs e)
        {
            Console.WriteLine("Bypass ready");
            dready = true;
        }
    }
}
