


















// Generated on 06/26/2015 11:41:11
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PlayerStatusUpdateMessage : NetworkMessage
{

public const uint Id = 6386;
public override uint MessageId
{
    get { return Id; }
}

public int accountId;
        public uint playerId;
        public Types.PlayerStatus status;
        

public PlayerStatusUpdateMessage()
{
}

public PlayerStatusUpdateMessage(int accountId, uint playerId, Types.PlayerStatus status)
        {
            this.accountId = accountId;
            this.playerId = playerId;
            this.status = status;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(accountId);
            writer.WriteVaruhint(playerId);
            writer.WriteShort(status.TypeId);
            status.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

accountId = reader.ReadInt();
            if (accountId < 0)
                throw new Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            playerId = reader.ReadVaruhint();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            status = Types.ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadShort());
            status.Deserialize(reader);
            

}


}


}