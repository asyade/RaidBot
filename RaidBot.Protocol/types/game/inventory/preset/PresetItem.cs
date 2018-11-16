


















// Generated on 06/26/2015 11:42:09
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class PresetItem
{

public const short Id = 354;
public virtual short TypeId
{
    get { return Id; }
}

public byte position;
        public ushort objGid;
        public uint objUid;
        

public PresetItem()
{
}

public PresetItem(byte position, ushort objGid, uint objUid)
        {
            this.position = position;
            this.objGid = objGid;
            this.objUid = objUid;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteByte(position);
            writer.WriteVaruhshort(objGid);
            writer.WriteVaruhint(objUid);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

position = reader.ReadByte();
            if (position < 0 || position > 255)
                throw new Exception("Forbidden value on position = " + position + ", it doesn't respect the following condition : position < 0 || position > 255");
            objGid = reader.ReadVaruhshort();
            if (objGid < 0)
                throw new Exception("Forbidden value on objGid = " + objGid + ", it doesn't respect the following condition : objGid < 0");
            objUid = reader.ReadVaruhint();
            if (objUid < 0)
                throw new Exception("Forbidden value on objUid = " + objUid + ", it doesn't respect the following condition : objUid < 0");
            

}


}


}