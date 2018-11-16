


















// Generated on 06/26/2015 11:40:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class IdentificationFailedForBadVersionMessage : IdentificationFailedMessage
{

public const uint Id = 21;
public override uint MessageId
{
    get { return Id; }
}

public Types.Version requiredVersion;
        

public IdentificationFailedForBadVersionMessage()
{
}

public IdentificationFailedForBadVersionMessage(sbyte reason, Types.Version requiredVersion)
         : base(reason)
        {
            this.requiredVersion = requiredVersion;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            requiredVersion.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            requiredVersion = new Types.Version();
            requiredVersion.Deserialize(reader);
            

}


}


}