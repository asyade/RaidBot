


















// Generated on 06/26/2015 11:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TeleportBuddiesRequestedMessage : NetworkMessage
{

public const uint Id = 6302;
public override uint MessageId
{
    get { return Id; }
}

public ushort dungeonId;
        public uint inviterId;
        public uint[] invalidBuddiesIds;
        

public TeleportBuddiesRequestedMessage()
{
}

public TeleportBuddiesRequestedMessage(ushort dungeonId, uint inviterId, uint[] invalidBuddiesIds)
        {
            this.dungeonId = dungeonId;
            this.inviterId = inviterId;
            this.invalidBuddiesIds = invalidBuddiesIds;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(dungeonId);
            writer.WriteVaruhint(inviterId);
            writer.WriteUShort((ushort)invalidBuddiesIds.Length);
            foreach (var entry in invalidBuddiesIds)
            {
                 writer.WriteVaruhint(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

dungeonId = reader.ReadVaruhshort();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            inviterId = reader.ReadVaruhint();
            if (inviterId < 0)
                throw new Exception("Forbidden value on inviterId = " + inviterId + ", it doesn't respect the following condition : inviterId < 0");
            var limit = reader.ReadUShort();
            invalidBuddiesIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 invalidBuddiesIds[i] = reader.ReadVaruhint();
            }
            

}


}


}