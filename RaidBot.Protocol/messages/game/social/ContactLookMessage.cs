


















// Generated on 06/26/2015 11:41:56
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ContactLookMessage : NetworkMessage
{

public const uint Id = 5934;
public override uint MessageId
{
    get { return Id; }
}

public uint requestId;
        public string playerName;
        public uint playerId;
        public Types.EntityLook look;
        

public ContactLookMessage()
{
}

public ContactLookMessage(uint requestId, string playerName, uint playerId, Types.EntityLook look)
        {
            this.requestId = requestId;
            this.playerName = playerName;
            this.playerId = playerId;
            this.look = look;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(requestId);
            writer.WriteUTF(playerName);
            writer.WriteVaruhint(playerId);
            look.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

requestId = reader.ReadVaruhint();
            if (requestId < 0)
                throw new Exception("Forbidden value on requestId = " + requestId + ", it doesn't respect the following condition : requestId < 0");
            playerName = reader.ReadUTF();
            playerId = reader.ReadVaruhint();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            look = new Types.EntityLook();
            look.Deserialize(reader);
            

}


}


}