using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class VersionExtended : Version
{

	public const uint Id = 393;
	public override uint MessageId { get { return Id; } }

	public byte Install { get; set; }
	public byte Technology { get; set; }

	public VersionExtended() {}


	public VersionExtended InitVersionExtended(byte Install, byte Technology)
	{
		this.Install = Install;
		this.Technology = Technology;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.Install);
		writer.WriteByte(this.Technology);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Install = reader.ReadByte();
		this.Technology = reader.ReadByte();
	}
}
}
