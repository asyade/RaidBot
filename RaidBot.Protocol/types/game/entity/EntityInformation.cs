using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class EntityInformation : NetworkType
{

	public const uint Id = 546;
	public override uint MessageId { get { return Id; } }

	public short Id_ { get; set; }
	public int Experience { get; set; }
	public bool Status { get; set; }

	public EntityInformation() {}


	public EntityInformation InitEntityInformation(short Id_, int Experience, bool Status)
	{
		this.Id_ = Id_;
		this.Experience = Experience;
		this.Status = Status;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.Id_);
		writer.WriteVarInt(this.Experience);
		writer.WriteBoolean(this.Status);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Id_ = reader.ReadVarShort();
		this.Experience = reader.ReadVarInt();
		this.Status = reader.ReadBoolean();
	}
}
}
