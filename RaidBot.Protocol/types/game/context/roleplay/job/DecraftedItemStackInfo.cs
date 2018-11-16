


















// Generated on 06/26/2015 11:42:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class DecraftedItemStackInfo
{

public const short Id = 481;
public virtual short TypeId
{
    get { return Id; }
}

public uint objectUID;
        public float bonusMin;
        public float bonusMax;
        public ushort[] runesId;
        public uint[] runesQty;
        

public DecraftedItemStackInfo()
{
}

public DecraftedItemStackInfo(uint objectUID, float bonusMin, float bonusMax, ushort[] runesId, uint[] runesQty)
        {
            this.objectUID = objectUID;
            this.bonusMin = bonusMin;
            this.bonusMax = bonusMax;
            this.runesId = runesId;
            this.runesQty = runesQty;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(objectUID);
            writer.WriteFloat(bonusMin);
            writer.WriteFloat(bonusMax);
            writer.WriteUShort((ushort)runesId.Length);
            foreach (var entry in runesId)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteUShort((ushort)runesQty.Length);
            foreach (var entry in runesQty)
            {
                 writer.WriteVaruhint(entry);
            }
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

objectUID = reader.ReadVaruhint();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            bonusMin = reader.ReadFloat();
            bonusMax = reader.ReadFloat();
            var limit = reader.ReadUShort();
            runesId = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 runesId[i] = reader.ReadVaruhshort();
            }
            limit = reader.ReadUShort();
            runesQty = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 runesQty[i] = reader.ReadVaruhint();
            }
            

}


}


}