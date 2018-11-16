


















// Generated on 06/26/2015 11:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildSpellUpgradeRequestMessage : NetworkMessage
{

public const uint Id = 5699;
public override uint MessageId
{
    get { return Id; }
}

public int spellId;
        

public GuildSpellUpgradeRequestMessage()
{
}

public GuildSpellUpgradeRequestMessage(int spellId)
        {
            this.spellId = spellId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(spellId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

spellId = reader.ReadInt();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            

}


}


}