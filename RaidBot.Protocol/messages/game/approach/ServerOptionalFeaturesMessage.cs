


















// Generated on 06/26/2015 11:41:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ServerOptionalFeaturesMessage : NetworkMessage
{

public const uint Id = 6305;
public override uint MessageId
{
    get { return Id; }
}

public sbyte[] features;
        

public ServerOptionalFeaturesMessage()
{
}

public ServerOptionalFeaturesMessage(sbyte[] features)
        {
            this.features = features;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)features.Length);
            foreach (var entry in features)
            {
                 writer.WriteSByte(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            features = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 features[i] = reader.ReadSByte();
            }
            

}


}


}