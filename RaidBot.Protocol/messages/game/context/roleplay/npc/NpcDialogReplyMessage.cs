using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class NpcDialogReplyMessage : NetworkMessage
{

	public const uint Id = 5616;
	public override uint MessageId { get { return Id; } }

	public int ReplyId { get; set; }

	public NpcDialogReplyMessage() {}


	public NpcDialogReplyMessage InitNpcDialogReplyMessage(int ReplyId)
	{
		this.ReplyId = ReplyId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.ReplyId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ReplyId = reader.ReadVarInt();
	}
}
}
