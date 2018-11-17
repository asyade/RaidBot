using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HavenBagDailyLoteryMessage : NetworkMessage
{

	public const uint Id = 6644;
	public override uint MessageId { get { return Id; } }

	public byte ReturnType { get; set; }
	public String GameActionId { get; set; }

	public HavenBagDailyLoteryMessage() {}


	public HavenBagDailyLoteryMessage InitHavenBagDailyLoteryMessage(byte ReturnType, String GameActionId)
	{
		this.ReturnType = ReturnType;
		this.GameActionId = GameActionId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.ReturnType);
		writer.WriteUTF(this.GameActionId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ReturnType = reader.ReadByte();
		this.GameActionId = reader.ReadUTF();
	}
}
}
