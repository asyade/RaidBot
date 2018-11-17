using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class SystemMessageDisplayMessage : NetworkMessage
{

	public const uint Id = 189;
	public override uint MessageId { get { return Id; } }

	public bool HangUp { get; set; }
	public short MsgId { get; set; }
	public String[] Parameters { get; set; }

	public SystemMessageDisplayMessage() {}


	public SystemMessageDisplayMessage InitSystemMessageDisplayMessage(bool HangUp, short MsgId, String[] Parameters)
	{
		this.HangUp = HangUp;
		this.MsgId = MsgId;
		this.Parameters = Parameters;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.HangUp);
		writer.WriteVarShort(this.MsgId);
		writer.WriteShort(this.Parameters.Length);
		foreach (String item in this.Parameters)
		{
			writer.WriteUTF(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.HangUp = reader.ReadBoolean();
		this.MsgId = reader.ReadVarShort();
		int ParametersLen = reader.ReadShort();
		Parameters = new String[ParametersLen];
		for (int i = 0; i < ParametersLen; i++)
		{
			this.Parameters[i] = reader.ReadUTF();
		}
	}
}
}
