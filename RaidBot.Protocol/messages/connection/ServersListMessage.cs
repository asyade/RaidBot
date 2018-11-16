


















// Generated on 06/26/2015 11:40:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ServersListMessage : NetworkMessage
{

public const uint Id = 30;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameServerInformations[] servers;
        public ushort alreadyConnectedToServerId;
        public bool canCreateNewCharacter;
        

public ServersListMessage()
{
}

public ServersListMessage(Types.GameServerInformations[] servers, ushort alreadyConnectedToServerId, bool canCreateNewCharacter)
        {
            this.servers = servers;
            this.alreadyConnectedToServerId = alreadyConnectedToServerId;
            this.canCreateNewCharacter = canCreateNewCharacter;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)servers.Length);
            foreach (var entry in servers)
            {
                 entry.Serialize(writer);
            }
            writer.WriteVaruhshort(alreadyConnectedToServerId);
            writer.WriteBoolean(canCreateNewCharacter);
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            servers = new Types.GameServerInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 servers[i] = new Types.GameServerInformations();
                 servers[i].Deserialize(reader);
            }
            alreadyConnectedToServerId = reader.ReadVaruhshort();
            if (alreadyConnectedToServerId < 0)
                throw new Exception("Forbidden value on alreadyConnectedToServerId = " + alreadyConnectedToServerId + ", it doesn't respect the following condition : alreadyConnectedToServerId < 0");
            canCreateNewCharacter = reader.ReadBoolean();
            

}


}


}