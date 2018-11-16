


















// Generated on 06/26/2015 11:41:02
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightInvisibleObstacleMessage : AbstractGameActionMessage
{

public const uint Id = 5820;
public override uint MessageId
{
    get { return Id; }
}

public uint sourceSpellId;
        

public GameActionFightInvisibleObstacleMessage()
{
}

public GameActionFightInvisibleObstacleMessage(ushort actionId, int sourceId, uint sourceSpellId)
         : base(actionId, sourceId)
        {
            this.sourceSpellId = sourceSpellId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(sourceSpellId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            sourceSpellId = reader.ReadVaruhint();
            if (sourceSpellId < 0)
                throw new Exception("Forbidden value on sourceSpellId = " + sourceSpellId + ", it doesn't respect the following condition : sourceSpellId < 0");
            

}


}


}