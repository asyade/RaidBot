


















// Generated on 06/26/2015 11:41:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class BasicLatencyStatsMessage : NetworkMessage
{

public const uint Id = 5663;
public override uint MessageId
{
    get { return Id; }
}

public ushort latency;
        public ushort sampleCount;
        public ushort max;
        

public BasicLatencyStatsMessage()
{
}

public BasicLatencyStatsMessage(ushort latency, ushort sampleCount, ushort max)
        {
            this.latency = latency;
            this.sampleCount = sampleCount;
            this.max = max;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort(latency);
            writer.WriteVaruhshort(sampleCount);
            writer.WriteVaruhshort(max);
            

}

public override void Deserialize(ICustomDataReader reader)
{

latency = reader.ReadUShort();
            if (latency < 0 || latency > 65535)
                throw new Exception("Forbidden value on latency = " + latency + ", it doesn't respect the following condition : latency < 0 || latency > 65535");
            sampleCount = reader.ReadVaruhshort();
            if (sampleCount < 0)
                throw new Exception("Forbidden value on sampleCount = " + sampleCount + ", it doesn't respect the following condition : sampleCount < 0");
            max = reader.ReadVaruhshort();
            if (max < 0)
                throw new Exception("Forbidden value on max = " + max + ", it doesn't respect the following condition : max < 0");
            

}


}


}