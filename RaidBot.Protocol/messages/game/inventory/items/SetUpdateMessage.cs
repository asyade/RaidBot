


















// Generated on 06/26/2015 11:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class SetUpdateMessage : NetworkMessage
{

public const uint Id = 5503;
public override uint MessageId
{
    get { return Id; }
}

public ushort setId;
        public ushort[] setObjects;
        public Types.ObjectEffect[] setEffects;
        

public SetUpdateMessage()
{
}

public SetUpdateMessage(ushort setId, ushort[] setObjects, Types.ObjectEffect[] setEffects)
        {
            this.setId = setId;
            this.setObjects = setObjects;
            this.setEffects = setEffects;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(setId);
            writer.WriteUShort((ushort)setObjects.Length);
            foreach (var entry in setObjects)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteUShort((ushort)setEffects.Length);
            foreach (var entry in setEffects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

setId = reader.ReadVaruhshort();
            if (setId < 0)
                throw new Exception("Forbidden value on setId = " + setId + ", it doesn't respect the following condition : setId < 0");
            var limit = reader.ReadUShort();
            setObjects = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 setObjects[i] = reader.ReadVaruhshort();
            }
            limit = reader.ReadUShort();
            setEffects = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 setEffects[i] = Types.ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadShort());
                 setEffects[i].Deserialize(reader);
            }
            

}


}


}