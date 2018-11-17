using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ServerOptionalFeaturesMessage : NetworkMessage
{

	public const uint Id = 6305;
	public override uint MessageId { get { return Id; } }

	public byte[] Features { get; set; }

	public ServerOptionalFeaturesMessage() {}


	public ServerOptionalFeaturesMessage InitServerOptionalFeaturesMessage(byte[] Features)
	{
		this.Features = Features;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.Features.Length);
		foreach (byte item in this.Features)
		{
			writer.WriteByte(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		int FeaturesLen = reader.ReadShort();
		Features = new byte[FeaturesLen];
		for (int i = 0; i < FeaturesLen; i++)
		{
			this.Features[i] = reader.ReadByte();
		}
	}
}
}
