


















// Generated on 06/26/2015 11:41:19
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MountFeedRequestMessage : NetworkMessage
{

public const uint Id = 6189;
public override uint MessageId
{
    get { return Id; }
}

public uint mountUid;
        public sbyte mountLocation;
        public uint mountFoodUid;
        public uint quantity;
        

public MountFeedRequestMessage()
{
}

public MountFeedRequestMessage(uint mountUid, sbyte mountLocation, uint mountFoodUid, uint quantity)
        {
            this.mountUid = mountUid;
            this.mountLocation = mountLocation;
            this.mountFoodUid = mountFoodUid;
            this.quantity = quantity;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(mountUid);
            writer.WriteSByte(mountLocation);
            writer.WriteVaruhint(mountFoodUid);
            writer.WriteVaruhint(quantity);
            

}

public override void Deserialize(ICustomDataReader reader)
{

mountUid = reader.ReadVaruhint();
            if (mountUid < 0)
                throw new Exception("Forbidden value on mountUid = " + mountUid + ", it doesn't respect the following condition : mountUid < 0");
            mountLocation = reader.ReadSByte();
            mountFoodUid = reader.ReadVaruhint();
            if (mountFoodUid < 0)
                throw new Exception("Forbidden value on mountFoodUid = " + mountFoodUid + ", it doesn't respect the following condition : mountFoodUid < 0");
            quantity = reader.ReadVaruhint();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}