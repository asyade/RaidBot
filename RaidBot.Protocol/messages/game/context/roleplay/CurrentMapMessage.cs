using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CurrentMapMessage : NetworkMessage
{

	public const uint Id = 220;
	public override uint MessageId { get { return Id; } }

	public double MapId { get; set; }
	public String MapKey { get; set; }

	public CurrentMapMessage() {}


	public CurrentMapMessage InitCurrentMapMessage(double MapId, String MapKey)
	{
		this.MapId = MapId;
		this.MapKey = MapKey;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.MapId);
		writer.WriteUTF(this.MapKey);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MapId = reader.ReadDouble();
		this.MapKey = reader.ReadUTF();
	}
}
}
