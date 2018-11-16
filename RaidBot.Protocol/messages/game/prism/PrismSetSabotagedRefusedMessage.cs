


















// Generated on 06/26/2015 11:41:54
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PrismSetSabotagedRefusedMessage : NetworkMessage
{

public const uint Id = 6466;
public override uint MessageId
{
    get { return Id; }
}

public ushort subAreaId;
        public sbyte reason;
        

public PrismSetSabotagedRefusedMessage()
{
}

public PrismSetSabotagedRefusedMessage(ushort subAreaId, sbyte reason)
        {
            this.subAreaId = subAreaId;
            this.reason = reason;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(subAreaId);
            writer.WriteSByte(reason);
            

}

public override void Deserialize(ICustomDataReader reader)
{

subAreaId = reader.ReadVaruhshort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            reason = reader.ReadSByte();
            

}


}


}