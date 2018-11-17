using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MimicryObjectEraseRequestMessage : NetworkMessage
{

	public const uint Id = 6457;
	public override uint MessageId { get { return Id; } }

	public int HostUID { get; set; }
	public byte HostPos { get; set; }

	public MimicryObjectEraseRequestMessage() {}


	public MimicryObjectEraseRequestMessage InitMimicryObjectEraseRequestMessage(int HostUID, byte HostPos)
	{
		this.HostUID = HostUID;
		this.HostPos = HostPos;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.HostUID);
		writer.WriteByte(this.HostPos);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.HostUID = reader.ReadVarInt();
		this.HostPos = reader.ReadByte();
	}
}
}
