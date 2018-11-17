using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class LivingObjectMessageMessage : NetworkMessage
{

	public const uint Id = 6065;
	public override uint MessageId { get { return Id; } }

	public short MsgId { get; set; }
	public int TimeStamp { get; set; }
	public String Owner { get; set; }
	public short ObjectGenericId { get; set; }

	public LivingObjectMessageMessage() {}


	public LivingObjectMessageMessage InitLivingObjectMessageMessage(short MsgId, int TimeStamp, String Owner, short ObjectGenericId)
	{
		this.MsgId = MsgId;
		this.TimeStamp = TimeStamp;
		this.Owner = Owner;
		this.ObjectGenericId = ObjectGenericId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.MsgId);
		writer.WriteInt(this.TimeStamp);
		writer.WriteUTF(this.Owner);
		writer.WriteVarShort(this.ObjectGenericId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MsgId = reader.ReadVarShort();
		this.TimeStamp = reader.ReadInt();
		this.Owner = reader.ReadUTF();
		this.ObjectGenericId = reader.ReadVarShort();
	}
}
}
