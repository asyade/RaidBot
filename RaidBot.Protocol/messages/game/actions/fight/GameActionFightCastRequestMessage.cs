


















// Generated on 06/26/2015 11:41:01
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightCastRequestMessage : NetworkMessage
{

public const uint Id = 1005;
public override uint MessageId
{
    get { return Id; }
}

public ushort spellId;
        public short cellId;
        

public GameActionFightCastRequestMessage()
{
}

public GameActionFightCastRequestMessage(ushort spellId, short cellId)
        {
            this.spellId = spellId;
            this.cellId = cellId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(spellId);
            writer.WriteShort(cellId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

spellId = reader.ReadVaruhshort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            cellId = reader.ReadShort();
            if (cellId < -1 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < -1 || cellId > 559");
            

}


}


}