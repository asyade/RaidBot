using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class EntityMovementInformations : NetworkType
{

	public const uint Id = 63;
	public override uint MessageId { get { return Id; } }

	public int Id_ { get; set; }
	public byte[] Steps { get; set; }

	public EntityMovementInformations() {}


	public EntityMovementInformations InitEntityMovementInformations(int Id_, byte[] Steps)
	{
		this.Id_ = Id_;
		this.Steps = Steps;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.Id_);
		writer.WriteShort(this.Steps.Length);
		foreach (byte item in this.Steps)
		{
			writer.WriteByte(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Id_ = reader.ReadInt();
		int StepsLen = reader.ReadShort();
		Steps = new byte[StepsLen];
		for (int i = 0; i < StepsLen; i++)
		{
			this.Steps[i] = reader.ReadByte();
		}
	}
}
}
