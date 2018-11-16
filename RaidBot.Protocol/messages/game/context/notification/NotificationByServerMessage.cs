


















// Generated on 06/26/2015 11:41:20
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class NotificationByServerMessage : NetworkMessage
{

public const uint Id = 6103;
public override uint MessageId
{
    get { return Id; }
}

public ushort id;
        public string[] parameters;
        public bool forceOpen;
        

public NotificationByServerMessage()
{
}

public NotificationByServerMessage(ushort id, string[] parameters, bool forceOpen)
        {
            this.id = id;
            this.parameters = parameters;
            this.forceOpen = forceOpen;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(id);
            writer.WriteUShort((ushort)parameters.Length);
            foreach (var entry in parameters)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteBoolean(forceOpen);
            

}

public override void Deserialize(ICustomDataReader reader)
{

id = reader.ReadVaruhshort();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            var limit = reader.ReadUShort();
            parameters = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 parameters[i] = reader.ReadUTF();
            }
            forceOpen = reader.ReadBoolean();
            

}


}


}