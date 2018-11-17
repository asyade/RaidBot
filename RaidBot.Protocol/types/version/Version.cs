using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class Version : NetworkType
{

	public const uint Id = 11;
	public override uint MessageId { get { return Id; } }

	public byte Major { get; set; }
	public byte Minor { get; set; }
	public byte Release { get; set; }
	public int Revision { get; set; }
	public byte Patch { get; set; }
	public byte BuildType { get; set; }

	public Version() {}


	public Version InitVersion(byte Major, byte Minor, byte Release, int Revision, byte Patch, byte BuildType)
	{
		this.Major = Major;
		this.Minor = Minor;
		this.Release = Release;
		this.Revision = Revision;
		this.Patch = Patch;
		this.BuildType = BuildType;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.Major);
		writer.WriteByte(this.Minor);
		writer.WriteByte(this.Release);
		writer.WriteInt(this.Revision);
		writer.WriteByte(this.Patch);
		writer.WriteByte(this.BuildType);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Major = reader.ReadByte();
		this.Minor = reader.ReadByte();
		this.Release = reader.ReadByte();
		this.Revision = reader.ReadInt();
		this.Patch = reader.ReadByte();
		this.BuildType = reader.ReadByte();
	}
}
}
