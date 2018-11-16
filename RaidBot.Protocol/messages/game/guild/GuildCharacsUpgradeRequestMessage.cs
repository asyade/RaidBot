


















// Generated on 06/26/2015 11:41:37
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildCharacsUpgradeRequestMessage : NetworkMessage
{

public const uint Id = 5706;
public override uint MessageId
{
    get { return Id; }
}

public sbyte charaTypeTarget;
        

public GuildCharacsUpgradeRequestMessage()
{
}

public GuildCharacsUpgradeRequestMessage(sbyte charaTypeTarget)
        {
            this.charaTypeTarget = charaTypeTarget;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(charaTypeTarget);
            

}

public override void Deserialize(ICustomDataReader reader)
{

charaTypeTarget = reader.ReadSByte();
            if (charaTypeTarget < 0)
                throw new Exception("Forbidden value on charaTypeTarget = " + charaTypeTarget + ", it doesn't respect the following condition : charaTypeTarget < 0");
            

}


}


}