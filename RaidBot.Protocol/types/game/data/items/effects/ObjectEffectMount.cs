


















// Generated on 06/26/2015 11:42:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class ObjectEffectMount : ObjectEffect
{

public const short Id = 179;
public override short TypeId
{
    get { return Id; }
}

public int mountId;
        public double date;
        public ushort modelId;
        

public ObjectEffectMount()
{
}

public ObjectEffectMount(ushort actionId, int mountId, double date, ushort modelId)
         : base(actionId)
        {
            this.mountId = mountId;
            this.date = date;
            this.modelId = modelId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(mountId);
            writer.WriteDouble(date);
            writer.WriteVaruhshort(modelId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            mountId = reader.ReadInt();
            if (mountId < 0)
                throw new Exception("Forbidden value on mountId = " + mountId + ", it doesn't respect the following condition : mountId < 0");
            date = reader.ReadDouble();
            if (date < -9.007199254740992E15 || date > 9.007199254740992E15)
                throw new Exception("Forbidden value on date = " + date + ", it doesn't respect the following condition : date < -9.007199254740992E15 || date > 9.007199254740992E15");
            modelId = reader.ReadVaruhshort();
            if (modelId < 0)
                throw new Exception("Forbidden value on modelId = " + modelId + ", it doesn't respect the following condition : modelId < 0");
            

}


}


}