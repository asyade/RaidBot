


















// Generated on 06/26/2015 11:41:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AllianceListMessage : NetworkMessage
{

public const uint Id = 6408;
public override uint MessageId
{
    get { return Id; }
}

public Types.AllianceFactSheetInformations[] alliances;
        

public AllianceListMessage()
{
}

public AllianceListMessage(Types.AllianceFactSheetInformations[] alliances)
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
            alliances = new Types.AllianceFactSheetInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 alliances[i] = new Types.AllianceFactSheetInformations();
                 alliances[i].Deserialize(reader);
            }
            

}


}


}