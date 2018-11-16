


















// Generated on 06/26/2015 11:42:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class ObjectItemToSellInBid : ObjectItemToSell
{

public const short Id = 164;
public override short TypeId
{
    get { return Id; }
}

public int unsoldDelay;
        

public ObjectItemToSellInBid()
{
}

public ObjectItemToSellInBid(ushort objectGID, Types.ObjectEffect[] effects, uint objectUID, uint quantity, uint objectPrice, int unsoldDelay)
         : base(objectGID, effects, objectUID, quantity, objectPrice)
        {
            this.unsoldDelay = unsoldDelay;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(unsoldDelay);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            unsoldDelay = reader.ReadInt();
            if (unsoldDelay < 0)
                throw new Exception("Forbidden value on unsoldDelay = " + unsoldDelay + ", it doesn't respect the following condition : unsoldDelay < 0");
            

}


}


}