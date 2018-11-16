


















// Generated on 06/26/2015 11:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildFactsMessage : NetworkMessage
{

public const uint Id = 6415;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildFactSheetInformations infos;
        public int creationDate;
        public ushort nbTaxCollectors;
        public bool enabled;
        public Types.CharacterMinimalInformations[] members;
        

public GuildFactsMessage()
{
}

public GuildFactsMessage(Types.GuildFactSheetInformations infos, int creationDate, ushort nbTaxCollectors, bool enabled, Types.CharacterMinimalInformations[] members)
        {
            this.infos = infos;
            this.creationDate = creationDate;
            this.nbTaxCollectors = nbTaxCollectors;
            this.enabled = enabled;
            this.members = members;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteShort(infos.TypeId);
            infos.Serialize(writer);
            writer.WriteInt(creationDate);
            writer.WriteVaruhshort(nbTaxCollectors);
            writer.WriteBoolean(enabled);
            writer.WriteUShort((ushort)members.Length);
            foreach (var entry in members)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

infos = Types.ProtocolTypeManager.GetInstance<Types.GuildFactSheetInformations>(reader.ReadShort());
            infos.Deserialize(reader);
            creationDate = reader.ReadInt();
            if (creationDate < 0)
                throw new Exception("Forbidden value on creationDate = " + creationDate + ", it doesn't respect the following condition : creationDate < 0");
            nbTaxCollectors = reader.ReadVaruhshort();
            if (nbTaxCollectors < 0)
                throw new Exception("Forbidden value on nbTaxCollectors = " + nbTaxCollectors + ", it doesn't respect the following condition : nbTaxCollectors < 0");
            enabled = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            members = new Types.CharacterMinimalInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 members[i] = new Types.CharacterMinimalInformations();
                 members[i].Deserialize(reader);
            }
            

}


}


}