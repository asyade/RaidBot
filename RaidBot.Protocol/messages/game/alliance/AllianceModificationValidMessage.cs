


















// Generated on 06/26/2015 11:41:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AllianceModificationValidMessage : NetworkMessage
{

public const uint Id = 6450;
public override uint MessageId
{
    get { return Id; }
}

public string allianceName;
        public string allianceTag;
        public Types.GuildEmblem Alliancemblem;
        

public AllianceModificationValidMessage()
{
}

public AllianceModificationValidMessage(string allianceName, string allianceTag, Types.GuildEmblem Alliancemblem)
        {
            this.allianceName = allianceName;
            this.allianceTag = allianceTag;
            this.Alliancemblem = Alliancemblem;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(allianceName);
            writer.WriteUTF(allianceTag);
            Alliancemblem.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

allianceName = reader.ReadUTF();
            allianceTag = reader.ReadUTF();
            Alliancemblem = new Types.GuildEmblem();
            Alliancemblem.Deserialize(reader);
            

}


}


}