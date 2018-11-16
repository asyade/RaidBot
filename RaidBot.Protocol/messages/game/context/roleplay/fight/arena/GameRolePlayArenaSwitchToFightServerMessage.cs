


















// Generated on 06/26/2015 11:41:23
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameRolePlayArenaSwitchToFightServerMessage : NetworkMessage
{

public const uint Id = 6575;
public override uint MessageId
{
    get { return Id; }
}

public string address;
        public ushort port;
        public sbyte[] ticket;
        

public GameRolePlayArenaSwitchToFightServerMessage()
{
}

public GameRolePlayArenaSwitchToFightServerMessage(string address, ushort port, sbyte[] ticket)
        {
            this.address = address;
            this.port = port;
            this.ticket = ticket;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(address);
            writer.WriteUShort(port);
            writer.WriteUShort((ushort)ticket.Length);
            foreach (var entry in ticket)
            {
                 writer.WriteSByte(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

address = reader.ReadUTF();
            port = reader.ReadUShort();
            if (port < 0 || port > 65535)
                throw new Exception("Forbidden value on port = " + port + ", it doesn't respect the following condition : port < 0 || port > 65535");
            var limit = reader.ReadUShort();
            ticket = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 ticket[i] = reader.ReadSByte();
            }
            

}


}


}