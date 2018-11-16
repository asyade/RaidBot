


















// Generated on 06/26/2015 11:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class DungeonPartyFinderRegisterSuccessMessage : NetworkMessage
{

public const uint Id = 6241;
public override uint MessageId
{
    get { return Id; }
}

public ushort[] dungeonIds;
        

public DungeonPartyFinderRegisterSuccessMessage()
{
}

public DungeonPartyFinderRegisterSuccessMessage(ushort[] dungeonIds)
        {
            this.dungeonIds = dungeonIds;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)dungeonIds.Length);
            foreach (var entry in dungeonIds)
            {
                 writer.WriteVaruhshort(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            dungeonIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 dungeonIds[i] = reader.ReadVaruhshort();
            }
            

}


}


}