


















// Generated on 06/26/2015 11:41:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class CheckIntegrityMessage : NetworkMessage
{

public const uint Id = 6372;
public override uint MessageId
{
    get { return Id; }
}

public sbyte[] data;
        

public CheckIntegrityMessage()
{
}

public CheckIntegrityMessage(sbyte[] data)
        {
            this.data = data;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)data.Length);
            foreach (var entry in data)
            {
                 writer.WriteSByte(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            data = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 data[i] = reader.ReadSByte();
            }
            

}


}


}