


















// Generated on 06/26/2015 11:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ObjectGroundListAddedMessage : NetworkMessage
{

public const uint Id = 5925;
public override uint MessageId
{
    get { return Id; }
}

public ushort[] cells;
        public ushort[] referenceIds;
        

public ObjectGroundListAddedMessage()
{
}

public ObjectGroundListAddedMessage(ushort[] cells, ushort[] referenceIds)
        {
            this.cells = cells;
            this.referenceIds = referenceIds;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)cells.Length);
            foreach (var entry in cells)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteUShort((ushort)referenceIds.Length);
            foreach (var entry in referenceIds)
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
            limit = reader.ReadUShort();
            referenceIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 referenceIds[i] = reader.ReadVaruhshort();
            }
            

}


}


}