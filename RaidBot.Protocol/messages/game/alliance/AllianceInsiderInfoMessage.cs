


















// Generated on 06/26/2015 11:41:05
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AllianceInsiderInfoMessage : NetworkMessage
{

public const uint Id = 6403;
public override uint MessageId
{
    get { return Id; }
}

public Types.AllianceFactSheetInformations allianceInfos;
        public Types.GuildInsiderFactSheetInformations[] guilds;
        public Types.PrismSubareaEmptyInfo[] prisms;
        

public AllianceInsiderInfoMessage()
{
}

public AllianceInsiderInfoMessage(Types.AllianceFactSheetInformations allianceInfos, Types.GuildInsiderFactSheetInformations[] guilds, Types.PrismSubareaEmptyInfo[] prisms)
        {
            this.allianceInfos = allianceInfos;
            this.guilds = guilds;
            this.prisms = prisms;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

allianceInfos.Serialize(writer);
            writer.WriteUShort((ushort)guilds.Length);
            foreach (var entry in guilds)
            {
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)prisms.Length);
            foreach (var entry in prisms)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

allianceInfos = new Types.AllianceFactSheetInformations();
            allianceInfos.Deserialize(reader);
            var limit = reader.ReadUShort();
            guilds = new Types.GuildInsiderFactSheetInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 guilds[i] = new Types.GuildInsiderFactSheetInformations();
                 guilds[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            prisms = new Types.PrismSubareaEmptyInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 prisms[i] = Types.ProtocolTypeManager.GetInstance<Types.PrismSubareaEmptyInfo>(reader.ReadShort());
                 prisms[i].Deserialize(reader);
            }
            

}


}


}