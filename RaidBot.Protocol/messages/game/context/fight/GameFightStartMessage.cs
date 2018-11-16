


















// Generated on 06/26/2015 11:41:17
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightStartMessage : NetworkMessage
{

public const uint Id = 712;
public override uint MessageId
{
    get { return Id; }
}

public Types.Idol[] idols;
        

public GameFightStartMessage()
{
}

public GameFightStartMessage(Types.Idol[] idols)
        {
            this.idols = idols;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)idols.Length);
            foreach (var entry in idols)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            idols = new Types.Idol[limit];
            for (int i = 0; i < limit; i++)
            {
                 idols[i] = new Types.Idol();
                 idols[i].Deserialize(reader);
            }
            

}


}


}