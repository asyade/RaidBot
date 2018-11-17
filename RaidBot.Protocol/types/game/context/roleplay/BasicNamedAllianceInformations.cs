using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class BasicNamedAllianceInformations : BasicAllianceInformations
{

	public const uint Id = 418;
	public override uint MessageId { get { return Id; } }

	public String AllianceName { get; set; }

	public BasicNamedAllianceInformations() {}


	public BasicNamedAllianceInformations InitBasicNamedAllianceInformations(String AllianceName)
	{
		this.AllianceName = AllianceName;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteUTF(this.AllianceName);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.AllianceName = reader.ReadUTF();
	}
}
}
