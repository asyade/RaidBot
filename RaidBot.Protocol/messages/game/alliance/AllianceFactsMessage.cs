using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AllianceFactsMessage : NetworkMessage
{

	public const uint Id = 6414;
	public override uint MessageId { get { return Id; } }

	public GuildInAllianceInformations[] Guilds { get; set; }
	public short[] ControlledSubareaIds { get; set; }
	public long LeaderCharacterId { get; set; }
	public String LeaderCharacterName { get; set; }

	public AllianceFactsMessage() {}


	public AllianceFactsMessage InitAllianceFactsMessage(GuildInAllianceInformations[] Guilds, short[] ControlledSubareaIds, long LeaderCharacterId, String LeaderCharacterName)
	{
		this.Guilds = Guilds;
		this.ControlledSubareaIds = ControlledSubareaIds;
		this.LeaderCharacterId = LeaderCharacterId;
		this.LeaderCharacterName = LeaderCharacterName;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.Guilds.Length);
		foreach (GuildInAllianceInformations item in this.Guilds)
		{
			item.Serialize(writer);
		}
		writer.WriteShort(this.ControlledSubareaIds.Length);
		foreach (short item in this.ControlledSubareaIds)
		{
			writer.WriteVarShort(item);
		}
		writer.WriteVarLong(this.LeaderCharacterId);
		writer.WriteUTF(this.LeaderCharacterName);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		int GuildsLen = reader.ReadShort();
		Guilds = new GuildInAllianceInformations[GuildsLen];
		for (int i = 0; i < GuildsLen; i++)
		{
			this.Guilds[i] = new GuildInAllianceInformations();
			this.Guilds[i].Deserialize(reader);
		}
		int ControlledSubareaIdsLen = reader.ReadShort();
		ControlledSubareaIds = new short[ControlledSubareaIdsLen];
		for (int i = 0; i < ControlledSubareaIdsLen; i++)
		{
			this.ControlledSubareaIds[i] = reader.ReadVarShort();
		}
		this.LeaderCharacterId = reader.ReadVarLong();
		this.LeaderCharacterName = reader.ReadUTF();
	}
}
}
