using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightOptionToggleMessage : NetworkMessage
{

	public const uint Id = 707;
	public override uint MessageId { get { return Id; } }

	public byte Option { get; set; }

	public GameFightOptionToggleMessage() {}


	public GameFightOptionToggleMessage InitGameFightOptionToggleMessage(byte Option)
	{
		this.Option = Option;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.Option);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Option = reader.ReadByte();
	}
}
}
