


















// Generated on 06/26/2015 11:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class LivingObjectMessageRequestMessage : NetworkMessage
{

public const uint Id = 6066;
public override uint MessageId
{
    get { return Id; }
}

public ushort msgId;
        public string[] parameters;
        public uint livingObject;
        

public LivingObjectMessageRequestMessage()
{
}

public LivingObjectMessageRequestMessage(ushort msgId, string[] parameters, uint livingObject)
        {
            this.msgId = msgId;
            this.parameters = parameters;
            this.livingObject = livingObject;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(msgId);
            writer.WriteUShort((ushort)parameters.Length);
            foreach (var entry in parameters)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteVaruhint(livingObject);
            

}

public override void Deserialize(ICustomDataReader reader)
{

msgId = reader.ReadVaruhshort();
            if (msgId < 0)
                throw new Exception("Forbidden value on msgId = " + msgId + ", it doesn't respect the following condition : msgId < 0");
            var limit = reader.ReadUShort();
            parameters = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 parameters[i] = reader.ReadUTF();
            }
            livingObject = reader.ReadVaruhint();
            if (livingObject < 0)
                throw new Exception("Forbidden value on livingObject = " + livingObject + ", it doesn't respect the following condition : livingObject < 0");
            

}


}


}