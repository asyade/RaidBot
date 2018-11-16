


















// Generated on 06/26/2015 11:41:15
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightHumanReadyStateMessage : NetworkMessage
{

public const uint Id = 740;
public override uint MessageId
{
    get { return Id; }
}

public uint characterId;
        public bool isReady;
        

public GameFightHumanReadyStateMessage()
{
}

public GameFightHumanReadyStateMessage(uint characterId, bool isReady)
        {
            this.characterId = characterId;
            this.isReady = isReady;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(characterId);
            writer.WriteBoolean(isReady);
            

}

public override void Deserialize(ICustomDataReader reader)
{

characterId = reader.ReadVaruhint();
            if (characterId < 0)
                throw new Exception("Forbidden value on characterId = " + characterId + ", it doesn't respect the following condition : characterId < 0");
            isReady = reader.ReadBoolean();
            

}


}


}