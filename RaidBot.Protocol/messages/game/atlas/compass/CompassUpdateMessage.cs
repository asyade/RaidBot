using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CompassUpdateMessage : NetworkMessage
{

	public const uint Id = 5591;
	public override uint MessageId { get { return Id; } }

	public byte Type { get; set; }

	public CompassUpdateMessage() {}


	public CompassUpdateMessage InitCompassUpdateMessage(byte Type)
	{
		this.Type = Type;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.Type);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Type = reader.ReadByte();
	}
}
}
