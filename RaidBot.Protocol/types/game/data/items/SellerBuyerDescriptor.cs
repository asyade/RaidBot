


















// Generated on 06/26/2015 11:42:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class SellerBuyerDescriptor
{

public const short Id = 121;
public virtual short TypeId
{
    get { return Id; }
}

public uint[] quantities;
        public uint[] types;
        public float taxPercentage;
        public float taxModificationPercentage;
        public byte maxItemLevel;
        public uint maxItemPerAccount;
        public int npcContextualId;
        public ushort unsoldDelay;
        

public SellerBuyerDescriptor()
{
}

public SellerBuyerDescriptor(uint[] quantities, uint[] types, float taxPercentage, float taxModificationPercentage, byte maxItemLevel, uint maxItemPerAccount, int npcContextualId, ushort unsoldDelay)
        {
            this.quantities = quantities;
            this.types = types;
            this.taxPercentage = taxPercentage;
            this.taxModificationPercentage = taxModificationPercentage;
            this.maxItemLevel = maxItemLevel;
            this.maxItemPerAccount = maxItemPerAccount;
            this.npcContextualId = npcContextualId;
            this.unsoldDelay = unsoldDelay;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)quantities.Length);
            foreach (var entry in quantities)
            {
                 writer.WriteVaruhint(entry);
            }
            writer.WriteUShort((ushort)types.Length);
            foreach (var entry in types)
            {
                 writer.WriteVaruhint(entry);
            }
            writer.WriteFloat(taxPercentage);
            writer.WriteFloat(taxModificationPercentage);
            writer.WriteByte(maxItemLevel);
            writer.WriteVaruhint(maxItemPerAccount);
            writer.WriteInt(npcContextualId);
            writer.WriteVaruhshort(unsoldDelay);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            quantities = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 quantities[i] = reader.ReadVaruhint();
            }
            limit = reader.ReadUShort();
            types = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 types[i] = reader.ReadVaruhint();
            }
            taxPercentage = reader.ReadFloat();
            taxModificationPercentage = reader.ReadFloat();
            maxItemLevel = reader.ReadByte();
            if (maxItemLevel < 0 || maxItemLevel > 255)
                throw new Exception("Forbidden value on maxItemLevel = " + maxItemLevel + ", it doesn't respect the following condition : maxItemLevel < 0 || maxItemLevel > 255");
            maxItemPerAccount = reader.ReadVaruhint();
            if (maxItemPerAccount < 0)
                throw new Exception("Forbidden value on maxItemPerAccount = " + maxItemPerAccount + ", it doesn't respect the following condition : maxItemPerAccount < 0");
            npcContextualId = reader.ReadInt();
            unsoldDelay = reader.ReadVaruhshort();
            if (unsoldDelay < 0)
                throw new Exception("Forbidden value on unsoldDelay = " + unsoldDelay + ", it doesn't respect the following condition : unsoldDelay < 0");
            

}


}


}