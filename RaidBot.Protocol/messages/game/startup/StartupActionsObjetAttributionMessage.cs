using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class StartupActionsObjetAttributionMessage : NetworkMessage
{

	public const uint Id = 1303;
	public override uint MessageId { get { return Id; } }

	public int ActionId { get; set; }
	public long CharacterId { get; set; }

	public StartupActionsObjetAttributionMessage() {}


	public StartupActionsObjetAttributionMessage InitStartupActionsObjetAttributionMessage(int ActionId, long CharacterId)
	{
		this.ActionId = ActionId;
		this.CharacterId = CharacterId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.ActionId);
		writer.WriteVarLong(this.CharacterId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ActionId = reader.ReadInt();
		this.CharacterId = reader.ReadVarLong();
	}
}
}
