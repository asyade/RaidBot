

using RaidBot.Engine.Bot;
using RaidBot.Engine.Daemon;
using System;
using System.Net;
using System.Threading.Tasks;

namespace RaidBot
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Daemon d = new Daemon();
            //Brain brain = new Brain(new BotConfig("acorbeau1", "Asyade123581321"));
            //brain.UpdateClient(new Common.Network.Client.Client(IPAddress.Parse("34.252.21.81"), 5555, new Common.Default.Loging.Logger()));
            Console.Read();
        }
    }
}
