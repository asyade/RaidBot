


















// Generated on 06/26/2015 11:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class StatsUpgradeRequestMessage : NetworkMessage
{

public const uint Id = 5610;
public override uint MessageId
{
    get { return Id; }
}

public bool useAdditionnal;
        public sbyte statId;
        public ushort boostPoint;
        

public StatsUpgradeRequestMessage()
{
}

public StatsUpgradeRequestMessage(bool useAdditionnal, sbyte statId, ushort boostPoint)
        {
            this.useAdditionnal = useAdditionnal;
            this.statId = statId;
            this.boostPoint = boostPoint;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(useAdditionnal);
            writer.WriteSByte(statId);
            writer.WriteVaruhshort(boostPoint);
            

}

public override void Deserialize(ICustomDataReader reader)
{

useAdditionnal = reader.ReadBoolean();
            statId = reader.ReadSByte();
            if (statId < 0)
                throw new Exception("Forbidden value on statId = " + statId + ", it doesn't respect the following condition : statId < 0");
            boostPoint = reader.ReadVaruhshort();
            if (boostPoint < 0)
                throw new Exception("Forbidden value on boostPoint = " + boostPoint + ", it doesn't respect the following condition : boostPoint < 0");
            

}


}


}