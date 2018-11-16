


















// Generated on 06/26/2015 11:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TeleportToBuddyAnswerMessage : NetworkMessage
{

public const uint Id = 6293;
public override uint MessageId
{
    get { return Id; }
}

public ushort dungeonId;
        public uint buddyId;
        public bool accept;
        

public TeleportToBuddyAnswerMessage()
{
}

public TeleportToBuddyAnswerMessage(ushort dungeonId, uint buddyId, bool accept)
        {
            this.dungeonId = dungeonId;
            this.buddyId = buddyId;
            this.accept = accept;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(dungeonId);
            writer.WriteVaruhint(buddyId);
            writer.WriteBoolean(accept);
            

}

public override void Deserialize(ICustomDataReader reader)
{

dungeonId = reader.ReadVaruhshort();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            buddyId = reader.ReadVaruhint();
            if (buddyId < 0)
                throw new Exception("Forbidden value on buddyId = " + buddyId + ", it doesn't respect the following condition : buddyId < 0");
            accept = reader.ReadBoolean();
            

}


}


}