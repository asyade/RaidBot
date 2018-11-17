using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PlayerStatusExtended : PlayerStatus
{

	public const uint Id = 414;
	public override uint MessageId { get { return Id; } }

	public String Message { get; set; }

	public PlayerStatusExtended() {}


	public PlayerStatusExtended InitPlayerStatusExtended(String Message)
	{
		this.Message = Message;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteUTF(this.Message);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Message = reader.ReadUTF();
	}
}
}
