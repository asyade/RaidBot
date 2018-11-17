using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MountEquipedErrorMessage : NetworkMessage
{

	public const uint Id = 5963;
	public override uint MessageId { get { return Id; } }

	public byte ErrorType { get; set; }

	public MountEquipedErrorMessage() {}


	public MountEquipedErrorMessage InitMountEquipedErrorMessage(byte ErrorType)
	{
		this.ErrorType = ErrorType;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.ErrorType);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ErrorType = reader.ReadByte();
	}
}
}
