


















// Generated on 06/26/2015 11:42:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class ObjectItemToSellInNpcShop : ObjectItemMinimalInformation
{

public const short Id = 352;
public override short TypeId
{
    get { return Id; }
}

public uint objectPrice;
        public string buyCriterion;
        

public ObjectItemToSellInNpcShop()
{
}

public ObjectItemToSellInNpcShop(ushort objectGID, Types.ObjectEffect[] effects, uint objectPrice, string buyCriterion)
         : base(objectGID, effects)
        {
            this.objectPrice = objectPrice;
            this.buyCriterion = buyCriterion;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(objectPrice);
            writer.WriteUTF(buyCriterion);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            objectPrice = reader.ReadVaruhint();
            if (objectPrice < 0)
                throw new Exception("Forbidden value on objectPrice = " + objectPrice + ", it doesn't respect the following condition : objectPrice < 0");
            buyCriterion = reader.ReadUTF();
            

}


}


}