using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class LivingObjectMessageRequestMessage : NetworkMessage
{

	public const uint Id = 6066;
	public override uint MessageId { get { return Id; } }

	public short MsgId { get; set; }
	public String[] Parameters { get; set; }
	public int LivingObject { get; set; }

	public LivingObjectMessageRequestMessage() {}


	public LivingObjectMessageRequestMessage InitLivingObjectMessageRequestMessage(short MsgId, String[] Parameters, int LivingObject)
	{
		this.MsgId = MsgId;
		this.Parameters = Parameters;
		this.LivingObject = LivingObject;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.MsgId);
		writer.WriteShort(this.Parameters.Length);
		foreach (String item in this.Parameters)
		{
			writer.WriteUTF(item);
		}
		writer.WriteVarInt(this.LivingObject);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MsgId = reader.ReadVarShort();
		int ParametersLen = reader.ReadShort();
		Parameters = new String[ParametersLen];
		for (int i = 0; i < ParametersLen; i++)
		{
			this.Parameters[i] = reader.ReadUTF();
		}
		this.LivingObject = reader.ReadVarInt();
	}
}
}
