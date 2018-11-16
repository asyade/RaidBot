


















// Generated on 06/26/2015 11:41:22
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameRolePlayDelayedObjectUseMessage : GameRolePlayDelayedActionMessage
{

public const uint Id = 6425;
public override uint MessageId
{
    get { return Id; }
}

public ushort objectGID;
        

public GameRolePlayDelayedObjectUseMessage()
{
}

public GameRolePlayDelayedObjectUseMessage(int delayedCharacterId, sbyte delayTypeId, double delayEndTime, ushort objectGID)
         : base(delayedCharacterId, delayTypeId, delayEndTime)
        {
            this.objectGID = objectGID;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(objectGID);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            objectGID = reader.ReadVaruhshort();
            if (objectGID < 0)
                throw new Exception("Forbidden value on objectGID = " + objectGID + ", it doesn't respect the following condition : objectGID < 0");
            

}


}


}