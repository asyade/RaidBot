using RaidBot.Common.IO;
using RaidBot.Common.Network.Client;
using RaidBot.Protocol.Types;
using RaidBot.Engine.Bot.Frames;
using RaidBot.Protocol.Messages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaidBot.Engine.Bot.Data;

namespace RaidBot.Engine.Bot
{
    public class Brain
    {
        public BotConfig Config { get;  }
        public Store State { get; }
        public Client Connection { get; set; }
        public Dispatcher.Dispatcher Dispatcher { get; }
        public uint GlobalInstanceId { get; set; }
 
        Dictionary<UInt32, Frame> frames;

        public Brain(BotConfig config)
        {
            this.Dispatcher = new Dispatcher.Dispatcher();

            GlobalInstanceId = 0;
            Config = config;
            State = new Store();

            frames = new Dictionary<uint, Frame>();
            frames.Add(AuthFrame.PREDICATE, new AuthFrame(this));
            frames.Add(CharacterSelectionFrame.PREDICATE, new CharacterSelectionFrame(this));
        }

        public void UpdateClient(Client newClient)
        {
            this.Connection = newClient;
            this.Connection.DataReceived += Connection_DataReceived;
            this.Connection.DataSended += Connection_DataSended;
            this.Connection.Connected += Connection_Connected;
            this.Connection.Disconnected += Connection_Disconnected;
        }

        private void Connection_Disconnected(object sender, Client.DisconnectedEventArgs e)
        {
            Console.WriteLine("Disconnected !");
        }

        private void Connection_Connected(object sender, Client.ConnectedEventArgs e)
        {
            Console.WriteLine("Connected !");
        }

        public void SendMessage(NetworkMessage message)
        {
            CustomDataWriter writer = new CustomDataWriter();
            message.Pack(writer, ++GlobalInstanceId);
            Connection.Send(writer.Data);
            
            Console.WriteLine(BitConverter.ToString(writer.Data));
        }

        private void Connection_DataReceived(object sender, Client.DataReceivedEventArgs e)
        {
            Console.WriteLine(BitConverter.ToString(e.Data.Data));
     
            NetworkMessage msg = ProtocolManager.GetPacket(e.Data.Data, (uint)e.Data.MessageId);
            this.GlobalInstanceId++;
            this.Dispatcher.DispatchMessage(msg, this);
        }

        private void Connection_DataSended(object sender, Client.DataSendedEventArgs e)
        {
        }

    }
}
