


















// Generated on 06/26/2015 11:41:10
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class CharacterNameSuggestionSuccessMessage : NetworkMessage
{

public const uint Id = 5544;
public override uint MessageId
{
    get { return Id; }
}

public string suggestion;
        

public CharacterNameSuggestionSuccessMessage()
{
}

public CharacterNameSuggestionSuccessMessage(string suggestion)
        {
            this.suggestion = suggestion;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(suggestion);
            

}

public override void Deserialize(ICustomDataReader reader)
{

suggestion = reader.ReadUTF();
            

}


}


}