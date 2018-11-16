


















// Generated on 06/26/2015 11:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildGetInformationsMessage : NetworkMessage
{

public const uint Id = 5550;
public override uint MessageId
{
    get { return Id; }
}

public sbyte infoType;
        

public GuildGetInformationsMessage()
{
}

public GuildGetInformationsMessage(sbyte infoType)
        {
            this.infoType = infoType;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(infoType);
            

}

public override void Deserialize(ICustomDataReader reader)
{

infoType = reader.ReadSByte();
            if (infoType < 0)
                throw new Exception("Forbidden value on infoType = " + infoType + ", it doesn't respect the following condition : infoType < 0");
            

}


}


}