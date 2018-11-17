using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MountInformationsForPaddock : NetworkType
{

	public const uint Id = 184;
	public override uint MessageId { get { return Id; } }

	public short ModelId { get; set; }
	public String Name { get; set; }
	public String OwnerName { get; set; }

	public MountInformationsForPaddock() {}


	public MountInformationsForPaddock InitMountInformationsForPaddock(short ModelId, String Name, String OwnerName)
	{
		this.ModelId = ModelId;
		this.Name = Name;
		this.OwnerName = OwnerName;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.ModelId);
		writer.WriteUTF(this.Name);
		writer.WriteUTF(this.OwnerName);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ModelId = reader.ReadVarShort();
		this.Name = reader.ReadUTF();
		this.OwnerName = reader.ReadUTF();
	}
}
}
