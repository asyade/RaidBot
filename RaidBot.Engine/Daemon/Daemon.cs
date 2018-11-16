using RaidBot.Common.Default.Loging;
using RaidBot.Common.IO;
using RaidBot.Common.Network.Client;
using RaidBot.Common.Network.Server;
using RaidBot.Protocol.Messages;
using RaidBot.Protocol.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidBot.Engine.Daemon
{
    public class Daemon
    {
        private Dispatcher.Dispatcher mDispatcher;
        private Server mServer;
        private Client slave;

        public event EventHandler<Action<String, IdentificationMessage>> AuthentificationLoaded;

        public Daemon()
        {
            mServer = new Server();
            mServer.ConnectionAccepted += MServer_ConnectionAccepted;
            mServer.Start(5555);
        }

        private void MServer_ConnectionAccepted(object sender, System.Net.Sockets.Socket acceptedSocket)
        {
            Console.WriteLine("Slave client connected !");
            slave = new Client(acceptedSocket, new Logger());
            mDispatcher = new Dispatcher.Dispatcher();
            slave.DataReceived += Slave_DataReceived;
            SendMessage(new ProtocolRequired(1878, 1890));
        }

        public void RequestAuthentificationMessage(String salt, sbyte[] key)
        {
            HelloConnect hello = new HelloConnect("jojhz9nm!qL:).W5tD6@jb6ePRLu4@a$", new sbyte[] { 52, -27, -18, -86, 97, 58, 54, 40, -34, -92, -101, -90, -11, -14, 26, -37, 106, 39, 67, -107, -39, -118, -122, 17, 74, -54, -49, -120, -60, -55, -98, -115, 88, 106, -112, 118, 54, 45, 64, 124, 107, 83, -87, -124, 118, 3, 94, 14, 99, -1, -72, 53, -26, -127, -106, -122, 10, -58, 61, -24, 92, -2, -117, 88, -32, -117, 119, 68, 18, 39, -118, 38, -61, -17, -126, 3, 10, 90, 58, -22, 63, 75, 127, 5, -71, 125, -95, 68, 22, -2, -93, -50, 20, -22, -19, -113, -120, 13, 54, 123, 8, 120, -53, 70, 63, -18, -102, 11, 6, 25, -75, 19, -126, -14, 17, 61, 112, 109, -23, -42, 15, 83, 1, 117, 2, 87, -121, -88, 6, -35, -12, -47, 101, 60, -49, 109, -103, -10, -92, -81, 13, 1, 85, -33, -81, -8, 102, 64, -30, 87, -20, -118, 3, -83, 44, 49, -95, 30, 72, 99, -14, -16, -21, -97, 105, 59, 118, -8, 39, -91, -106, 45, -4, -53, -24, 118, 115, -47, -60, 77, -107, -107, -99, 36, -125, -77, -9, 95, 103, -119, -88, -16, -41, 11, -29, 47, 2, 112, -52, -56, -25, -107, -48, 61, 66, -60, 109, -65, 8, 95, -55, 1, 43, 55, 99, 89, -52, 80, 19, -29, 94, 44, 15, 1, 61, -25, 64, -94, -82, 51, 10, -117, 37, 19, -58, 76, -60, -7, 46, -36, 105, -110, -100, 92, -103, 28, 34, -1, 18, 73, 65, 57, -108, 118, -124, -95, 65, -17, -48, 114, 60, 92, 115, -57, 33, -46, 12, -85, -4, 31, -32, 103, 48, 13, -29, 121, 83, -14, -127, -20, -58, -78, 64, 10, -75, 115, 79, -74, 4, 30, 33, -25, 29, 21, -68, 115, -101, -98, -3, -1, 98, 77, 80, -53, 4 });
            SendMessage(hello);
        }

        private void SendMessage(NetworkMessage message)
        {
            var st = new CustomDataWriter();
            message.PackOld(st);
            slave.Send(st.Data);
        }

        private void Slave_DataReceived(object sender, Client.DataReceivedEventArgs e)
        {
            if (e.Data.MessageId == IdentificationMessage.Id)
            {
                
            }
        }
    }
}
