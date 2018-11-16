


















// Generated on 06/26/2015 11:41:13
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MoodSmileyUpdateMessage : NetworkMessage
{

public const uint Id = 6388;
public override uint MessageId
{
    get { return Id; }
}

public int accountId;
        public uint playerId;
        public sbyte smileyId;
        

public MoodSmileyUpdateMessage()
{
}

public MoodSmileyUpdateMessage(int accountId, uint playerId, sbyte smileyId)
        {
            this.accountId = accountId;
            this.playerId = playerId;
            this.smileyId = smileyId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(accountId);
            writer.WriteVaruhint(playerId);
            writer.WriteSByte(smileyId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

accountId = reader.ReadInt();
            if (accountId < 0)
                throw new Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            playerId = reader.ReadVaruhint();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            smileyId = reader.ReadSByte();
            

}


}


}