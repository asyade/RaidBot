using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PrismUseRequestMessage : NetworkMessage
{

	public const uint Id = 6041;
	public override uint MessageId { get { return Id; } }

	public byte ModuleToUse { get; set; }

	public PrismUseRequestMessage() {}


	public PrismUseRequestMessage InitPrismUseRequestMessage(byte ModuleToUse)
	{
		this.ModuleToUse = ModuleToUse;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.ModuleToUse);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ModuleToUse = reader.ReadByte();
	}
}
}
