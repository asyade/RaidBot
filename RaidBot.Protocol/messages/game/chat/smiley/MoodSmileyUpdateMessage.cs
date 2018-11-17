using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MoodSmileyUpdateMessage : NetworkMessage
{

	public const uint Id = 6388;
	public override uint MessageId { get { return Id; } }

	public int AccountId { get; set; }
	public long PlayerId { get; set; }
	public short SmileyId { get; set; }

	public MoodSmileyUpdateMessage() {}


	public MoodSmileyUpdateMessage InitMoodSmileyUpdateMessage(int AccountId, long PlayerId, short SmileyId)
	{
		this.AccountId = AccountId;
		this.PlayerId = PlayerId;
		this.SmileyId = SmileyId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.AccountId);
		writer.WriteVarLong(this.PlayerId);
		writer.WriteVarShort(this.SmileyId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.AccountId = reader.ReadInt();
		this.PlayerId = reader.ReadVarLong();
		this.SmileyId = reader.ReadVarShort();
	}
}
}
