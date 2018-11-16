


















// Generated on 06/26/2015 11:41:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class SystemMessageDisplayMessage : NetworkMessage
{

public const uint Id = 189;
public override uint MessageId
{
    get { return Id; }
}

public bool hangUp;
        public ushort msgId;
        public string[] parameters;
        

public SystemMessageDisplayMessage()
{
}

public SystemMessageDisplayMessage(bool hangUp, ushort msgId, string[] parameters)
        {
            this.hangUp = hangUp;
            this.msgId = msgId;
            this.parameters = parameters;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(hangUp);
            writer.WriteVaruhshort(msgId);
            writer.WriteUShort((ushort)parameters.Length);
            foreach (var entry in parameters)
            {
                 writer.WriteUTF(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

hangUp = reader.ReadBoolean();
            msgId = reader.ReadVaruhshort();
            if (msgId < 0)
                throw new Exception("Forbidden value on msgId = " + msgId + ", it doesn't respect the following condition : msgId < 0");
            var limit = reader.ReadUShort();
            parameters = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 parameters[i] = reader.ReadUTF();
            }
            

}


}


}