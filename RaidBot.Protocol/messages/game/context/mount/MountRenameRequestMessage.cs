using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MountRenameRequestMessage : NetworkMessage
{

	public const uint Id = 5987;
	public override uint MessageId { get { return Id; } }

	public String Name { get; set; }
	public int MountId { get; set; }

	public MountRenameRequestMessage() {}


	public MountRenameRequestMessage InitMountRenameRequestMessage(String Name, int MountId)
	{
		this.Name = Name;
		this.MountId = MountId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.Name);
		writer.WriteVarInt(this.MountId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Name = reader.ReadUTF();
		this.MountId = reader.ReadVarInt();
	}
}
}
