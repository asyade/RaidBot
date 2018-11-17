using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class BasicAllianceInformations : AbstractSocialGroupInfos
{

	public const uint Id = 419;
	public override uint MessageId { get { return Id; } }

	public int AllianceId { get; set; }
	public String AllianceTag { get; set; }

	public BasicAllianceInformations() {}


	public BasicAllianceInformations InitBasicAllianceInformations(int AllianceId, String AllianceTag)
	{
		this.AllianceId = AllianceId;
		this.AllianceTag = AllianceTag;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarInt(this.AllianceId);
		writer.WriteUTF(this.AllianceTag);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.AllianceId = reader.ReadVarInt();
		this.AllianceTag = reader.ReadUTF();
	}
}
}
