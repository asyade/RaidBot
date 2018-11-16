


















// Generated on 06/26/2015 11:41:22
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class EmotePlayMassiveMessage : EmotePlayAbstractMessage
{

public const uint Id = 5691;
public override uint MessageId
{
    get { return Id; }
}

public int[] actorIds;
        

public EmotePlayMassiveMessage()
{
}

public EmotePlayMassiveMessage(byte emoteId, double emoteStartTime, int[] actorIds)
         : base(emoteId, emoteStartTime)
        {
            this.actorIds = actorIds;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)actorIds.Length);
            foreach (var entry in actorIds)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            actorIds = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 actorIds[i] = reader.ReadInt();
            }
            

}


}


}