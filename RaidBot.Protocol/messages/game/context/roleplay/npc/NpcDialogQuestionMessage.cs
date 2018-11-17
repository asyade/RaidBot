using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class NpcDialogQuestionMessage : NetworkMessage
{

	public const uint Id = 5617;
	public override uint MessageId { get { return Id; } }

	public int MessageId_ { get; set; }
	public String[] DialogParams { get; set; }
	public int[] VisibleReplies { get; set; }

	public NpcDialogQuestionMessage() {}


	public NpcDialogQuestionMessage InitNpcDialogQuestionMessage(int MessageId_, String[] DialogParams, int[] VisibleReplies)
	{
		this.MessageId_ = MessageId_;
		this.DialogParams = DialogParams;
		this.VisibleReplies = VisibleReplies;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.MessageId_);
		writer.WriteShort(this.DialogParams.Length);
		foreach (String item in this.DialogParams)
		{
			writer.WriteUTF(item);
		}
		writer.WriteShort(this.VisibleReplies.Length);
		foreach (int item in this.VisibleReplies)
		{
			writer.WriteVarInt(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MessageId_ = reader.ReadVarInt();
		int DialogParamsLen = reader.ReadShort();
		DialogParams = new String[DialogParamsLen];
		for (int i = 0; i < DialogParamsLen; i++)
		{
			this.DialogParams[i] = reader.ReadUTF();
		}
		int VisibleRepliesLen = reader.ReadShort();
		VisibleReplies = new int[VisibleRepliesLen];
		for (int i = 0; i < VisibleRepliesLen; i++)
		{
			this.VisibleReplies[i] = reader.ReadVarInt();
		}
	}
}
}
