


















// Generated on 06/26/2015 11:41:01
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightCastOnTargetRequestMessage : NetworkMessage
{

public const uint Id = 6330;
public override uint MessageId
{
    get { return Id; }
}

public ushort spellId;
        public int targetId;
        

public GameActionFightCastOnTargetRequestMessage()
{
}

public GameActionFightCastOnTargetRequestMessage(ushort spellId, int targetId)
        {
            this.spellId = spellId;
            this.targetId = targetId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(spellId);
            writer.WriteInt(targetId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

spellId = reader.ReadVaruhshort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            targetId = reader.ReadInt();
            

}


}


}