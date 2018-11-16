


















// Generated on 06/26/2015 11:40:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class SelectedServerDataMessage : NetworkMessage
{

public const uint Id = 42;
public override uint MessageId
{
    get { return Id; }
}

        public ushort serverId;
        public string address;
        public ushort port;
        public bool canCreateNewCharacter;
        public sbyte[] ticket;
        

public SelectedServerDataMessage()
{
}

public SelectedServerDataMessage(ushort serverId, string address, ushort port, bool canCreateNewCharacter, sbyte[] ticket)
        {
            this.serverId = serverId;
            this.address = address;
            this.port = port;
            this.canCreateNewCharacter = canCreateNewCharacter;
            this.ticket = ticket;
        }
        

public override void Serialize(ICustomDataWriter writer)
{
            writer.WriteVaruhshort(serverId);
            writer.WriteUTF(address);
            writer.WriteUShort(port);
            writer.WriteBoolean(canCreateNewCharacter);
            writer.WriteVarint((int)(ushort)ticket.Length);
            foreach (var entry in ticket)
            {
                 writer.WriteSByte(entry);
            }
}

public override void Deserialize(ICustomDataReader reader)
{

            serverId = reader.ReadVaruhshort();
            if (serverId < 0)
                throw new Exception("Forbidden value on serverId = " + serverId + ", it doesn't respect the following condition : serverId < 0");
            address = reader.ReadUTF();
            port = reader.ReadUShort();
            if (port < 0 || port > 65535)
                throw new Exception("Forbidden value on port = " + port + ", it doesn't respect the following condition : port < 0 || port > 65535");
           canCreateNewCharacter = reader.ReadBoolean();
			var limit = (ushort)reader.ReadVarint();
            ticket = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 ticket[i] = reader.ReadSByte();
            }
            

}


}


}