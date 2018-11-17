using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyInvitationDungeonMessage : PartyInvitationMessage
{

	public const uint Id = 6244;
	public override uint MessageId { get { return Id; } }

	public short DungeonId { get; set; }

	public PartyInvitationDungeonMessage() {}


	public PartyInvitationDungeonMessage InitPartyInvitationDungeonMessage(short DungeonId)
	{
		this.DungeonId = DungeonId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.DungeonId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.DungeonId = reader.ReadVarShort();
	}
}
}
