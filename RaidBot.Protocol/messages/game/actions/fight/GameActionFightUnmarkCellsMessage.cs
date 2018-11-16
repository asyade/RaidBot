


















// Generated on 06/26/2015 11:41:04
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightUnmarkCellsMessage : AbstractGameActionMessage
{

public const uint Id = 5570;
public override uint MessageId
{
    get { return Id; }
}

public short markId;
        

public GameActionFightUnmarkCellsMessage()
{
}

public GameActionFightUnmarkCellsMessage(ushort actionId, int sourceId, short markId)
         : base(actionId, sourceId)
        {
            this.markId = markId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(markId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            markId = reader.ReadShort();
            

}


}


}