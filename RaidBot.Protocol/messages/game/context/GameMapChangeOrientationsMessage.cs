


















// Generated on 06/26/2015 11:41:14
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameMapChangeOrientationsMessage : NetworkMessage
{

public const uint Id = 6155;
public override uint MessageId
{
    get { return Id; }
}

public Types.ActorOrientation[] orientations;
        

public GameMapChangeOrientationsMessage()
{
}

public GameMapChangeOrientationsMessage(Types.ActorOrientation[] orientations)
        {
            this.orientations = orientations;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)orientations.Length);
            foreach (var entry in orientations)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            orientations = new Types.ActorOrientation[limit];
            for (int i = 0; i < limit; i++)
            {
                 orientations[i] = new Types.ActorOrientation();
                 orientations[i].Deserialize(reader);
            }
            

}


}


}