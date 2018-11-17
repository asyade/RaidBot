using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HumanOptionAlliance : HumanOption
{

	public const uint Id = 425;
	public override uint MessageId { get { return Id; } }

	public AllianceInformations AllianceInformations { get; set; }
	public byte Aggressable { get; set; }

	public HumanOptionAlliance() {}


	public HumanOptionAlliance InitHumanOptionAlliance(AllianceInformations AllianceInformations, byte Aggressable)
	{
		this.AllianceInformations = AllianceInformations;
		this.Aggressable = Aggressable;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		this.AllianceInformations.Serialize(writer);
		writer.WriteByte(this.Aggressable);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.AllianceInformations = new AllianceInformations();
		this.AllianceInformations.Deserialize(reader);
		this.Aggressable = reader.ReadByte();
	}
}
}
