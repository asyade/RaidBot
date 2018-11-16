


















// Generated on 06/26/2015 11:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class EntityTalkMessage : NetworkMessage
{

public const uint Id = 6110;
public override uint MessageId
{
    get { return Id; }
}

public int entityId;
        public ushort textId;
        public string[] parameters;
        

public EntityTalkMessage()
{
}

public EntityTalkMessage(int entityId, ushort textId, string[] parameters)
        {
            this.entityId = entityId;
            this.textId = textId;
            this.parameters = parameters;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(entityId);
            writer.WriteVaruhshort(textId);
            writer.WriteUShort((ushort)parameters.Length);
            foreach (var entry in parameters)
            {
                 writer.WriteUTF(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

entityId = reader.ReadInt();
            textId = reader.ReadVaruhshort();
            if (textId < 0)
                throw new Exception("Forbidden value on textId = " + textId + ", it doesn't respect the following condition : textId < 0");
            var limit = reader.ReadUShort();
            parameters = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 parameters[i] = reader.ReadUTF();
            }
            

}


}


}