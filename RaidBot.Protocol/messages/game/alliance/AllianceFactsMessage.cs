


















// Generated on 06/26/2015 11:41:05
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AllianceFactsMessage : NetworkMessage
{

public const uint Id = 6414;
public override uint MessageId
{
    get { return Id; }
}

public Types.AllianceFactSheetInformations infos;
        public Types.GuildInAllianceInformations[] guilds;
        public ushort[] controlledSubareaIds;
        public uint leaderCharacterId;
        public string leaderCharacterName;
        

public AllianceFactsMessage()
{
}

public AllianceFactsMessage(Types.AllianceFactSheetInformations infos, Types.GuildInAllianceInformations[] guilds, ushort[] controlledSubareaIds, uint leaderCharacterId, string leaderCharacterName)
        {
            this.infos = infos;
            this.guilds = guilds;
            this.controlledSubareaIds = controlledSubareaIds;
            this.leaderCharacterId = leaderCharacterId;
            this.leaderCharacterName = leaderCharacterName;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteShort(infos.TypeId);
            infos.Serialize(writer);
            writer.WriteUShort((ushort)guilds.Length);
            foreach (var entry in guilds)
            {
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)controlledSubareaIds.Length);
            foreach (var entry in controlledSubareaIds)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteVaruhint(leaderCharacterId);
            writer.WriteUTF(leaderCharacterName);
            

}

public override void Deserialize(ICustomDataReader reader)
{

infos = Types.ProtocolTypeManager.GetInstance<Types.AllianceFactSheetInformations>(reader.ReadShort());
            infos.Deserialize(reader);
            var limit = reader.ReadUShort();
            guilds = new Types.GuildInAllianceInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 guilds[i] = new Types.GuildInAllianceInformations();
                 guilds[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            controlledSubareaIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 controlledSubareaIds[i] = reader.ReadVaruhshort();
            }
            leaderCharacterId = reader.ReadVaruhint();
            if (leaderCharacterId < 0)
                throw new Exception("Forbidden value on leaderCharacterId = " + leaderCharacterId + ", it doesn't respect the following condition : leaderCharacterId < 0");
            leaderCharacterName = reader.ReadUTF();
            

}


}


}