using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AlliancedGuildFactSheetInformations : GuildInformations
{

	public const uint Id = 422;
	public override uint MessageId { get { return Id; } }

	public BasicNamedAllianceInformations AllianceInfos { get; set; }

	public AlliancedGuildFactSheetInformations() {}


	public AlliancedGuildFactSheetInformations InitAlliancedGuildFactSheetInformations(BasicNamedAllianceInformations AllianceInfos)
	{
		this.AllianceInfos = AllianceInfos;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		this.AllianceInfos.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.AllianceInfos = new BasicNamedAllianceInformations();
		this.AllianceInfos.Deserialize(reader);
	}
}
}
