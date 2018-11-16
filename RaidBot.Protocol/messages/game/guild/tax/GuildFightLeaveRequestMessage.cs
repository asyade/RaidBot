


















// Generated on 06/26/2015 11:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildFightLeaveRequestMessage : NetworkMessage
{

public const uint Id = 5715;
public override uint MessageId
{
    get { return Id; }
}

public int taxCollectorId;
        public uint characterId;
        

public GuildFightLeaveRequestMessage()
{
}

public GuildFightLeaveRequestMessage(int taxCollectorId, uint characterId)
        {
            this.taxCollectorId = taxCollectorId;
            this.characterId = characterId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(taxCollectorId);
            writer.WriteVaruhint(characterId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

taxCollectorId = reader.ReadInt();
            if (taxCollectorId < 0)
                throw new Exception("Forbidden value on taxCollectorId = " + taxCollectorId + ", it doesn't respect the following condition : taxCollectorId < 0");
            characterId = reader.ReadVaruhint();
            if (characterId < 0)
                throw new Exception("Forbidden value on characterId = " + characterId + ", it doesn't respect the following condition : characterId < 0");
            

}


}


}