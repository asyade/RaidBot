


















// Generated on 06/26/2015 11:42:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class BidExchangerObjectInfo
{

public const short Id = 122;
public virtual short TypeId
{
    get { return Id; }
}

public uint objectUID;
        public Types.ObjectEffect[] effects;
        public int[] prices;
        

public BidExchangerObjectInfo()
{
}

public BidExchangerObjectInfo(uint objectUID, Types.ObjectEffect[] effects, int[] prices)
        {
            this.objectUID = objectUID;
            this.effects = effects;
            this.prices = prices;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(objectUID);
            writer.WriteUShort((ushort)effects.Length);
            foreach (var entry in effects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)prices.Length);
            foreach (var entry in prices)
            {
                 writer.WriteInt(entry);
            }
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

objectUID = reader.ReadVaruhint();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            var limit = reader.ReadUShort();
            effects = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 effects[i] = Types.ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadShort());
                 effects[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            prices = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 prices[i] = reader.ReadInt();
            }
            

}


}


}