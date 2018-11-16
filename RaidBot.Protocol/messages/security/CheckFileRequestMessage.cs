


















// Generated on 06/26/2015 11:41:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class CheckFileRequestMessage : NetworkMessage
{

public const uint Id = 6154;
public override uint MessageId
{
    get { return Id; }
}

public string filename;
        public sbyte type;
        

public CheckFileRequestMessage()
{
}

public CheckFileRequestMessage(string filename, sbyte type)
        {
            this.filename = filename;
            this.type = type;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(filename);
            writer.WriteSByte(type);
            

}

public override void Deserialize(ICustomDataReader reader)
{

filename = reader.ReadUTF();
            type = reader.ReadSByte();
            if (type < 0)
                throw new Exception("Forbidden value on type = " + type + ", it doesn't respect the following condition : type < 0");
            

}


}


}