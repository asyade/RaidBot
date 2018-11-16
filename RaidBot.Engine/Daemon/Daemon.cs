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
        private Queue<KeyValuePair<String, sbyte[]>> mRequests;

        public event EventHandler<IdentificationLoadedEventArgs> AuthentificationLoaded;
        public event EventHandler<EventArgs> Ready;

        public Daemon()
        {
            mRequests = new Queue<KeyValuePair<string, sbyte[]>>();
            mServer = new Server();
            mServer.ConnectionAccepted += MServer_ConnectionAccepted;
            mServer.Start(5555);
        }

        private void MServer_ConnectionAccepted(object sender, System.Net.Sockets.Socket acceptedSocket)
        {
            Console.WriteLine("Slave Slave client connected !");
            slave = new Client(acceptedSocket, new Logger(), true);
            mDispatcher = new Dispatcher.Dispatcher();
            slave.DataReceived += Slave_DataReceived;
            SendMessage(new ProtocolRequired(1878, 1890));
            Ready(this, new EventArgs());
        }

        public void RequestAuthentificationMessage(String salt, sbyte[] key)
        {
            mRequests.Enqueue(new KeyValuePair<String, sbyte[]>(salt, key));
            SendMessage(new HelloConnect(salt, key));
        }

        private void SendMessage(NetworkMessage message)
        {
            var st = new CustomDataWriter();
            message.PackOld(st);
            slave.Send(st.Data);
        }

        private void Slave_DataReceived(object sender, Client.DataReceivedEventArgs e)
        {
            NetworkMessage msg = ProtocolManager.GetPacket(e.Data.Data, (uint)e.Data.MessageId);
            if (e.Data.MessageId == IdentificationMessage.Id)
            {
                Console.WriteLine(BitConverter.ToString(e.Data.Data));
                msg.Deserialize(new CustomDataReader(msg.Data));
                KeyValuePair<String, sbyte[]> req = mRequests.Dequeue();
                Console.WriteLine("Slave Thx slave");
                AuthentificationLoaded(this, new IdentificationLoadedEventArgs(req.Key, (IdentificationMessage)msg));
            }
        }

        public class IdentificationLoadedEventArgs: EventArgs
        {
            public String Salt;
            public IdentificationMessage Msg;

            public IdentificationLoadedEventArgs(String salt, IdentificationMessage msg)
            {
                Salt = salt;
                Msg = msg;
            }

        }
    }
}
