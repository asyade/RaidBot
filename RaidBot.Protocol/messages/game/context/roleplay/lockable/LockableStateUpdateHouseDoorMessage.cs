


















// Generated on 06/26/2015 11:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class LockableStateUpdateHouseDoorMessage : LockableStateUpdateAbstractMessage
{

public const uint Id = 5668;
public override uint MessageId
{
    get { return Id; }
}

public uint houseId;
        

public LockableStateUpdateHouseDoorMessage()
{
}

public LockableStateUpdateHouseDoorMessage(bool locked, uint houseId)
         : base(locked)
        {
            this.houseId = houseId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(houseId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            houseId = reader.ReadVaruhint();
            if (houseId < 0)
                throw new Exception("Forbidden value on houseId = " + houseId + ", it doesn't respect the following condition : houseId < 0");
            

}


}


}