using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PlayerStatus : NetworkType
{

	public const uint Id = 415;
	public override uint MessageId { get { return Id; } }

	public byte StatusId { get; set; }

	public PlayerStatus() {}


	public PlayerStatus InitPlayerStatus(byte StatusId)
	{
		this.StatusId = StatusId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.StatusId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.StatusId = reader.ReadByte();
	}
}
}
