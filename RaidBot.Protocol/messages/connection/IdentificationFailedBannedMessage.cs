


















// Generated on 06/26/2015 11:40:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class IdentificationFailedBannedMessage : IdentificationFailedMessage
{

public const uint Id = 6174;
public override uint MessageId
{
    get { return Id; }
}

public double banEndDate;
        

public IdentificationFailedBannedMessage()
{
}

public IdentificationFailedBannedMessage(sbyte reason, double banEndDate)
         : base(reason)
        {
            this.banEndDate = banEndDate;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(banEndDate);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            banEndDate = reader.ReadDouble();
            if (banEndDate < 0 || banEndDate > 9.007199254740992E15)
                throw new Exception("Forbidden value on banEndDate = " + banEndDate + ", it doesn't respect the following condition : banEndDate < 0 || banEndDate > 9.007199254740992E15");
            

}


}


}