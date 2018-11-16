


















// Generated on 06/26/2015 11:41:54
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AccessoryPreviewRequestMessage : NetworkMessage
{

public const uint Id = 6518;
public override uint MessageId
{
    get { return Id; }
}

public ushort[] genericId;
        

public AccessoryPreviewRequestMessage()
{
}

public AccessoryPreviewRequestMessage(ushort[] genericId)
        {
            this.genericId = genericId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)genericId.Length);
            foreach (var entry in genericId)
            {
                 writer.WriteVaruhshort(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            genericId = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 genericId[i] = reader.ReadVaruhshort();
            }
            

}


}


}