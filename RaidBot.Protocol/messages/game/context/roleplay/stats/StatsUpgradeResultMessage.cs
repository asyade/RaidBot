


















// Generated on 06/26/2015 11:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class StatsUpgradeResultMessage : NetworkMessage
{

public const uint Id = 5609;
public override uint MessageId
{
    get { return Id; }
}

public sbyte result;
        public ushort nbCharacBoost;
        

public StatsUpgradeResultMessage()
{
}

public StatsUpgradeResultMessage(sbyte result, ushort nbCharacBoost)
        {
            this.result = result;
            this.nbCharacBoost = nbCharacBoost;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(result);
            writer.WriteVaruhshort(nbCharacBoost);
            

}

public override void Deserialize(ICustomDataReader reader)
{

result = reader.ReadSByte();
            nbCharacBoost = reader.ReadVaruhshort();
            if (nbCharacBoost < 0)
                throw new Exception("Forbidden value on nbCharacBoost = " + nbCharacBoost + ", it doesn't respect the following condition : nbCharacBoost < 0");
            

}


}


}