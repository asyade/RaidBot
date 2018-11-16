


















// Generated on 06/26/2015 11:41:55
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PrismSettingsRequestMessage : NetworkMessage
{

public const uint Id = 6437;
public override uint MessageId
{
    get { return Id; }
}

public ushort subAreaId;
        public sbyte startDefenseTime;
        

public PrismSettingsRequestMessage()
{
}

public PrismSettingsRequestMessage(ushort subAreaId, sbyte startDefenseTime)
        {
            this.subAreaId = subAreaId;
            this.startDefenseTime = startDefenseTime;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(subAreaId);
            writer.WriteSByte(startDefenseTime);
            

}

public override void Deserialize(ICustomDataReader reader)
{

subAreaId = reader.ReadVaruhshort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            startDefenseTime = reader.ReadSByte();
            if (startDefenseTime < 0)
                throw new Exception("Forbidden value on startDefenseTime = " + startDefenseTime + ", it doesn't respect the following condition : startDefenseTime < 0");
            

}


}


}