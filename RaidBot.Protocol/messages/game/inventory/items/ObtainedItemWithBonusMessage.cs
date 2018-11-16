


















// Generated on 06/26/2015 11:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ObtainedItemWithBonusMessage : ObtainedItemMessage
{

public const uint Id = 6520;
public override uint MessageId
{
    get { return Id; }
}

public uint bonusQuantity;
        

public ObtainedItemWithBonusMessage()
{
}

public ObtainedItemWithBonusMessage(ushort genericId, uint baseQuantity, uint bonusQuantity)
         : base(genericId, baseQuantity)
        {
            this.bonusQuantity = bonusQuantity;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(bonusQuantity);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            bonusQuantity = reader.ReadVaruhint();
            if (bonusQuantity < 0)
                throw new Exception("Forbidden value on bonusQuantity = " + bonusQuantity + ", it doesn't respect the following condition : bonusQuantity < 0");
            

}


}


}