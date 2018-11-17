using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class EntityTalkMessage : NetworkMessage
{

	public const uint Id = 6110;
	public override uint MessageId { get { return Id; } }

	public double EntityId { get; set; }
	public short TextId { get; set; }
	public String[] Parameters { get; set; }

	public EntityTalkMessage() {}


	public EntityTalkMessage InitEntityTalkMessage(double EntityId, short TextId, String[] Parameters)
	{
		this.EntityId = EntityId;
		this.TextId = TextId;
		this.Parameters = Parameters;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.EntityId);
		writer.WriteVarShort(this.TextId);
		writer.WriteShort(this.Parameters.Length);
		foreach (String item in this.Parameters)
		{
			writer.WriteUTF(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.EntityId = reader.ReadDouble();
		this.TextId = reader.ReadVarShort();
		int ParametersLen = reader.ReadShort();
		Parameters = new String[ParametersLen];
		for (int i = 0; i < ParametersLen; i++)
		{
			this.Parameters[i] = reader.ReadUTF();
		}
	}
}
}
