


















// Generated on 06/26/2015 11:41:23
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameRolePlayPlayerFightRequestMessage : NetworkMessage
{

public const uint Id = 5731;
public override uint MessageId
{
    get { return Id; }
}

public uint targetId;
        public short targetCellId;
        public bool friendly;
        

public GameRolePlayPlayerFightRequestMessage()
{
}

public GameRolePlayPlayerFightRequestMessage(uint targetId, short targetCellId, bool friendly)
        {
            this.targetId = targetId;
            this.targetCellId = targetCellId;
            this.friendly = friendly;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(targetId);
            writer.WriteShort(targetCellId);
            writer.WriteBoolean(friendly);
            

}

public override void Deserialize(ICustomDataReader reader)
{

targetId = reader.ReadVaruhint();
            if (targetId < 0)
                throw new Exception("Forbidden value on targetId = " + targetId + ", it doesn't respect the following condition : targetId < 0");
            targetCellId = reader.ReadShort();
            if (targetCellId < -1 || targetCellId > 559)
                throw new Exception("Forbidden value on targetCellId = " + targetCellId + ", it doesn't respect the following condition : targetCellId < -1 || targetCellId > 559");
            friendly = reader.ReadBoolean();
            

}


}


}