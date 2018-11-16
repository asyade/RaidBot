


















// Generated on 06/26/2015 11:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ObjectUseOnCharacterMessage : ObjectUseMessage
{

public const uint Id = 3003;
public override uint MessageId
{
    get { return Id; }
}

public uint characterId;
        

public ObjectUseOnCharacterMessage()
{
}

public ObjectUseOnCharacterMessage(uint objectUID, uint characterId)
         : base(objectUID)
        {
            this.characterId = characterId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(characterId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            characterId = reader.ReadVaruhint();
            if (characterId < 0)
                throw new Exception("Forbidden value on characterId = " + characterId + ", it doesn't respect the following condition : characterId < 0");
            

}


}


}