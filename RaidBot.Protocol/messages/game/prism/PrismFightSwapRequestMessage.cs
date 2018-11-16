


















// Generated on 06/26/2015 11:41:54
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PrismFightSwapRequestMessage : NetworkMessage
{

public const uint Id = 5901;
public override uint MessageId
{
    get { return Id; }
}

public ushort subAreaId;
        public uint targetId;
        

public PrismFightSwapRequestMessage()
{
}

public PrismFightSwapRequestMessage(ushort subAreaId, uint targetId)
        {
            this.subAreaId = subAreaId;
            this.targetId = targetId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(subAreaId);
            writer.WriteVaruhint(targetId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

subAreaId = reader.ReadVaruhshort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            targetId = reader.ReadVaruhint();
            if (targetId < 0)
                throw new Exception("Forbidden value on targetId = " + targetId + ", it doesn't respect the following condition : targetId < 0");
            

}


}


}