


















// Generated on 06/26/2015 11:42:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class ObjectItemMinimalInformation : Item
{

public const short Id = 124;
public override short TypeId
{
    get { return Id; }
}

public ushort objectGID;
        public Types.ObjectEffect[] effects;
        

public ObjectItemMinimalInformation()
{
}

public ObjectItemMinimalInformation(ushort objectGID, Types.ObjectEffect[] effects)
        {
            this.objectGID = objectGID;
            this.effects = effects;
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
            

}


}


}