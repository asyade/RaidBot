using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MountRenamedMessage : NetworkMessage
{

	public const uint Id = 5983;
	public override uint MessageId { get { return Id; } }

	public int MountId { get; set; }
	public String Name { get; set; }

	public MountRenamedMessage() {}


	public MountRenamedMessage InitMountRenamedMessage(int MountId, String Name)
	{
		this.MountId = MountId;
		this.Name = Name;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.MountId);
		writer.WriteUTF(this.Name);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MountId = reader.ReadVarInt();
		this.Name = reader.ReadUTF();
	}
}
}
