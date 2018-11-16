


















// Generated on 06/26/2015 11:40:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AcquaintanceServerListMessage : NetworkMessage
{

public const uint Id = 6142;
public override uint MessageId
{
    get { return Id; }
}

public ushort[] servers;
        

public AcquaintanceServerListMessage()
{
}

public AcquaintanceServerListMessage(ushort[] servers)
        {
            this.servers = servers;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)servers.Length);
            foreach (var entry in servers)
            {
                 writer.WriteVaruhshort(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            servers = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 servers[i] = reader.ReadVaruhshort();
            }
            

}


}


}