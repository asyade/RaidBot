using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AllianceModificationValidMessage : NetworkMessage
{

	public const uint Id = 6450;
	public override uint MessageId { get { return Id; } }

	public String AllianceName { get; set; }
	public String AllianceTag { get; set; }
	public GuildEmblem Alliancemblem { get; set; }

	public AllianceModificationValidMessage() {}


	public AllianceModificationValidMessage InitAllianceModificationValidMessage(String AllianceName, String AllianceTag, GuildEmblem Alliancemblem)
	{
		this.AllianceName = AllianceName;
		this.AllianceTag = AllianceTag;
		this.Alliancemblem = Alliancemblem;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.AllianceName);
		writer.WriteUTF(this.AllianceTag);
		this.Alliancemblem.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.AllianceName = reader.ReadUTF();
		this.AllianceTag = reader.ReadUTF();
		this.Alliancemblem = new GuildEmblem();
		this.Alliancemblem.Deserialize(reader);
	}
}
}
