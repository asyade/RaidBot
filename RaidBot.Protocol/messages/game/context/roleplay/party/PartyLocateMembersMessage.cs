


















// Generated on 06/26/2015 11:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyLocateMembersMessage : AbstractPartyMessage
{

public const uint Id = 5595;
public override uint MessageId
{
    get { return Id; }
}

public Types.PartyMemberGeoPosition[] geopositions;
        

public PartyLocateMembersMessage()
{
}

public PartyLocateMembersMessage(uint partyId, Types.PartyMemberGeoPosition[] geopositions)
         : base(partyId)
        {
            this.geopositions = geopositions;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)geopositions.Length);
            foreach (var entry in geopositions)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            geopositions = new Types.PartyMemberGeoPosition[limit];
            for (int i = 0; i < limit; i++)
            {
                 geopositions[i] = new Types.PartyMemberGeoPosition();
                 geopositions[i].Deserialize(reader);
            }
            

}


}


}