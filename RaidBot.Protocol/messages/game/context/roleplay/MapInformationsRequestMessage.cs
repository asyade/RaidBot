using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MapInformationsRequestMessage : NetworkMessage
{

	public const uint Id = 225;
	public override uint MessageId { get { return Id; } }

	public double MapId { get; set; }

	public MapInformationsRequestMessage() {}


	public MapInformationsRequestMessage InitMapInformationsRequestMessage(double MapId)
	{
		this.MapId = MapId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.MapId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MapId = reader.ReadDouble();
	}
}
}
