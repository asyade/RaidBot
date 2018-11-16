


















// Generated on 06/26/2015 11:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ObjectGroundRemovedMultipleMessage : NetworkMessage
{

public const uint Id = 5944;
public override uint MessageId
{
    get { return Id; }
}

public ushort[] cells;
        

public ObjectGroundRemovedMultipleMessage()
{
}

public ObjectGroundRemovedMultipleMessage(ushort[] cells)
        {
            this.cells = cells;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)cells.Length);
            foreach (var entry in cells)
            {
                 writer.WriteVaruhshort(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            cells = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 cells[i] = reader.ReadVaruhshort();
            }
            

}


}


}