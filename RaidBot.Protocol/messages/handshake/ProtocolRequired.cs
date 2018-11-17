using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ProtocolRequired : NetworkMessage
{

	public const uint Id = 1;
	public override uint MessageId { get { return Id; } }

	public int RequiredVersion { get; set; }
	public int CurrentVersion { get; set; }

	public ProtocolRequired() {}


	public ProtocolRequired InitProtocolRequired(int RequiredVersion, int CurrentVersion)
	{
		this.RequiredVersion = RequiredVersion;
		this.CurrentVersion = CurrentVersion;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.RequiredVersion);
		writer.WriteInt(this.CurrentVersion);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.RequiredVersion = reader.ReadInt();
		this.CurrentVersion = reader.ReadInt();
	}
}
}
