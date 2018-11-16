


















// Generated on 06/26/2015 11:41:10
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class CharacterLevelUpMessage : NetworkMessage
{

public const uint Id = 5670;
public override uint MessageId
{
    get { return Id; }
}

public byte newLevel;
        

public CharacterLevelUpMessage()
{
}

public CharacterLevelUpMessage(byte newLevel)
        {
            this.newLevel = newLevel;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteByte(newLevel);
            

}

public override void Deserialize(ICustomDataReader reader)
{

newLevel = reader.ReadByte();
            if (newLevel < 2 || newLevel > 200)
                throw new Exception("Forbidden value on newLevel = " + newLevel + ", it doesn't respect the following condition : newLevel < 2 || newLevel > 200");
            

}


}


}