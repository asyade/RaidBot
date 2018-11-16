


















// Generated on 06/26/2015 11:41:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AlliancePartialListMessage : AllianceListMessage
{

public const uint Id = 6427;
public override uint MessageId
{
    get { return Id; }
}



public AlliancePartialListMessage()
{
}

public AlliancePartialListMessage(Types.AllianceFactSheetInformations[] alliances)
         : base(alliances)
        {
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            

}


}


}