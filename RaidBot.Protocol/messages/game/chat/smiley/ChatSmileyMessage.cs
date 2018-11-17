using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ChatSmileyMessage : NetworkMessage
{

	public const uint Id = 801;
	public override uint MessageId { get { return Id; } }

	public double EntityId { get; set; }
	public short SmileyId { get; set; }
	public int AccountId { get; set; }

	public ChatSmileyMessage() {}


	public ChatSmileyMessage InitChatSmileyMessage(double EntityId, short SmileyId, int AccountId)
	{
		this.EntityId = EntityId;
		this.SmileyId = SmileyId;
		this.AccountId = AccountId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.EntityId);
		writer.WriteVarShort(this.SmileyId);
		writer.WriteInt(this.AccountId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.EntityId = reader.ReadDouble();
		this.SmileyId = reader.ReadVarShort();
		this.AccountId = reader.ReadInt();
	}
}
}
