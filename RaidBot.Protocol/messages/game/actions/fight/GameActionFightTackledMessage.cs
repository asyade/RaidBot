


















// Generated on 06/26/2015 11:41:04
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightTackledMessage : AbstractGameActionMessage
{

public const uint Id = 1004;
public override uint MessageId
{
    get { return Id; }
}

public int[] tacklersIds;
        

public GameActionFightTackledMessage()
{
}

public GameActionFightTackledMessage(ushort actionId, int sourceId, int[] tacklersIds)
         : base(actionId, sourceId)
        {
            this.tacklersIds = tacklersIds;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)tacklersIds.Length);
            foreach (var entry in tacklersIds)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            tacklersIds = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 tacklersIds[i] = reader.ReadInt();
            }
            

}


}


}