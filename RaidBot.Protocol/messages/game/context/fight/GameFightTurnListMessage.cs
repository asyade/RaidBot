


















// Generated on 06/26/2015 11:41:17
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightTurnListMessage : NetworkMessage
{

public const uint Id = 713;
public override uint MessageId
{
    get { return Id; }
}

public int[] ids;
        public int[] deadsIds;
        

public GameFightTurnListMessage()
{
}

public GameFightTurnListMessage(int[] ids, int[] deadsIds)
        {
            this.ids = ids;
            this.deadsIds = deadsIds;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)ids.Length);
            foreach (var entry in ids)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteUShort((ushort)deadsIds.Length);
            foreach (var entry in deadsIds)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            ids = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 ids[i] = reader.ReadInt();
            }
            limit = reader.ReadUShort();
            deadsIds = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 deadsIds[i] = reader.ReadInt();
            }
            

}


}


}