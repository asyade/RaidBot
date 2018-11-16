


















// Generated on 06/26/2015 11:41:03
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightMarkCellsMessage : AbstractGameActionMessage
{

public const uint Id = 5540;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameActionMark mark;
        

public GameActionFightMarkCellsMessage()
{
}

public GameActionFightMarkCellsMessage(ushort actionId, int sourceId, Types.GameActionMark mark)
         : base(actionId, sourceId)
        {
            this.mark = mark;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            mark.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            mark = new Types.GameActionMark();
            mark.Deserialize(reader);
            

}


}


}