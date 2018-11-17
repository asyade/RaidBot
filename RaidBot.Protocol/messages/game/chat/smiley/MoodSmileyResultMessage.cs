using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MoodSmileyResultMessage : NetworkMessage
{

	public const uint Id = 6196;
	public override uint MessageId { get { return Id; } }

	public byte ResultCode { get; set; }
	public short SmileyId { get; set; }

	public MoodSmileyResultMessage() {}


	public MoodSmileyResultMessage InitMoodSmileyResultMessage(byte ResultCode, short SmileyId)
	{
		this.ResultCode = ResultCode;
		this.SmileyId = SmileyId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.ResultCode);
		writer.WriteVarShort(this.SmileyId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ResultCode = reader.ReadByte();
		this.SmileyId = reader.ReadVarShort();
	}
}
}
