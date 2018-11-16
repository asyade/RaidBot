


















// Generated on 06/26/2015 11:41:15
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class DungeonKeyRingMessage : NetworkMessage
{

public const uint Id = 6299;
public override uint MessageId
{
    get { return Id; }
}

public ushort[] availables;
        public ushort[] unavailables;
        

public DungeonKeyRingMessage()
{
}

public DungeonKeyRingMessage(ushort[] availables, ushort[] unavailables)
        {
            this.availables = availables;
            this.unavailables = unavailables;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)availables.Length);
            foreach (var entry in availables)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteUShort((ushort)unavailables.Length);
            foreach (var entry in unavailables)
            {
                 writer.WriteVaruhshort(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            availables = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 availables[i] = reader.ReadVaruhshort();
            }
            limit = reader.ReadUShort();
            unavailables = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 unavailables[i] = reader.ReadVaruhshort();
            }
            

}


}


}