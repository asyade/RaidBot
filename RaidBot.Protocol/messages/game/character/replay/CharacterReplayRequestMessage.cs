


















// Generated on 06/26/2015 11:41:10
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class CharacterReplayRequestMessage : NetworkMessage
{

public const uint Id = 167;
public override uint MessageId
{
    get { return Id; }
}

public int characterId;
        

public CharacterReplayRequestMessage()
{
}

public CharacterReplayRequestMessage(int characterId)
        {
            this.characterId = characterId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(characterId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

characterId = reader.ReadInt();
            if (characterId < 0)
                throw new Exception("Forbidden value on characterId = " + characterId + ", it doesn't respect the following condition : characterId < 0");
            

}


}


}