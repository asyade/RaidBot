


















// Generated on 06/26/2015 11:41:55
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PrismsInfoValidMessage : NetworkMessage
{

public const uint Id = 6451;
public override uint MessageId
{
    get { return Id; }
}

public Types.PrismFightersInformation[] fights;
        

public PrismsInfoValidMessage()
{
}

public PrismsInfoValidMessage(Types.PrismFightersInformation[] fights)
        {
            this.fights = fights;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)fights.Length);
            foreach (var entry in fights)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            fights = new Types.PrismFightersInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 fights[i] = new Types.PrismFightersInformation();
                 fights[i].Deserialize(reader);
            }
            

}


}


}