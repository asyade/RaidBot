


















// Generated on 06/26/2015 11:42:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class ObjectItemToSellInHumanVendorShop : Item
{

public const short Id = 359;
public override short TypeId
{
    get { return Id; }
}

public ushort objectGID;
        public Types.ObjectEffect[] effects;
        public uint objectUID;
        public uint quantity;
        public uint objectPrice;
        public uint publicPrice;
        

public ObjectItemToSellInHumanVendorShop()
{
}

public ObjectItemToSellInHumanVendorShop(ushort objectGID, Types.ObjectEffect[] effects, uint objectUID, uint quantity, uint objectPrice, uint publicPrice)
        {
            this.objectGID = objectGID;
            this.effects = effects;
            this.objectUID = objectUID;
            this.quantity = quantity;
            this.objectPrice = objectPrice;
            this.publicPrice = publicPrice;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(objectGID);
            writer.WriteUShort((ushort)effects.Length);
            foreach (var entry in effects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteVaruhint(objectUID);
            writer.WriteVaruhint(quantity);
            writer.WriteVaruhint(objectPrice);
            writer.WriteVaruhint(publicPrice);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            objectGID = reader.ReadVaruhshort();
            if (objectGID < 0)
                throw new Exception("Forbidden value on objectGID = " + objectGID + ", it doesn't respect the following condition : objectGID < 0");
            var limit = reader.ReadUShort();
            effects = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 effects[i] = Types.ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadShort());
                 effects[i].Deserialize(reader);
            }
            objectUID = reader.ReadVaruhint();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            quantity = reader.ReadVaruhint();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            objectPrice = reader.ReadVaruhint();
            if (objectPrice < 0)
                throw new Exception("Forbidden value on objectPrice = " + objectPrice + ", it doesn't respect the following condition : objectPrice < 0");
            publicPrice = reader.ReadVaruhint();
            if (publicPrice < 0)
                throw new Exception("Forbidden value on publicPrice = " + publicPrice + ", it doesn't respect the following condition : publicPrice < 0");
            

}


}


}