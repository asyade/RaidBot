using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class LeaveDialogMessage : NetworkMessage
{

	public const uint Id = 5502;
	public override uint MessageId { get { return Id; } }

	public byte DialogType { get; set; }

	public LeaveDialogMessage() {}


	public LeaveDialogMessage InitLeaveDialogMessage(byte DialogType)
	{
		this.DialogType = DialogType;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.DialogType);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.DialogType = reader.ReadByte();
	}
}
}
