


















// Generated on 06/26/2015 11:41:22
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameRolePlayDelayedActionMessage : NetworkMessage
{

public const uint Id = 6153;
public override uint MessageId
{
    get { return Id; }
}

public int delayedCharacterId;
        public sbyte delayTypeId;
        public double delayEndTime;
        

public GameRolePlayDelayedActionMessage()
{
}

public GameRolePlayDelayedActionMessage(int delayedCharacterId, sbyte delayTypeId, double delayEndTime)
        {
            this.delayedCharacterId = delayedCharacterId;
            this.delayTypeId = delayTypeId;
            this.delayEndTime = delayEndTime;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(delayedCharacterId);
            writer.WriteSByte(delayTypeId);
            writer.WriteDouble(delayEndTime);
            

}

public override void Deserialize(ICustomDataReader reader)
{

delayedCharacterId = reader.ReadInt();
            delayTypeId = reader.ReadSByte();
            if (delayTypeId < 0)
                throw new Exception("Forbidden value on delayTypeId = " + delayTypeId + ", it doesn't respect the following condition : delayTypeId < 0");
            delayEndTime = reader.ReadDouble();
            if (delayEndTime < 0 || delayEndTime > 9.007199254740992E15)
                throw new Exception("Forbidden value on delayEndTime = " + delayEndTime + ", it doesn't respect the following condition : delayEndTime < 0 || delayEndTime > 9.007199254740992E15");
            

}


}


}