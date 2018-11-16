


















// Generated on 06/26/2015 11:41:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AllianceVersatileInfoListMessage : NetworkMessage
{

public const uint Id = 6436;
public override uint MessageId
{
    get { return Id; }
}

public Types.AllianceVersatileInformations[] alliances;
        

public AllianceVersatileInfoListMessage()
{
}

public AllianceVersatileInfoListMessage(Types.AllianceVersatileInformations[] alliances)
        {
            this.alliances = alliances;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)alliances.Length);
            foreach (var entry in alliances)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            alliances = new Types.AllianceVersatileInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 alliances[i] = new Types.AllianceVersatileInformations();
                 alliances[i].Deserialize(reader);
            }
            

}


}


}