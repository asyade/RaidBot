


















// Generated on 06/26/2015 11:41:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartInfoMessage : NetworkMessage
{

public const uint Id = 1508;
public override uint MessageId
{
    get { return Id; }
}

public Types.ContentPart part;
        public float installationPercent;
        

public PartInfoMessage()
{
}

public PartInfoMessage(Types.ContentPart part, float installationPercent)
        {
            this.part = part;
            this.installationPercent = installationPercent;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

part.Serialize(writer);
            writer.WriteFloat(installationPercent);
            

}

public override void Deserialize(ICustomDataReader reader)
{

part = new Types.ContentPart();
            part.Deserialize(reader);
            installationPercent = reader.ReadFloat();
            

}


}


}