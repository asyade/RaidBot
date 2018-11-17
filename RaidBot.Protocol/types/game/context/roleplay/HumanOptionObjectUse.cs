using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HumanOptionObjectUse : HumanOption
{

	public const uint Id = 449;
	public override uint MessageId { get { return Id; } }

	public byte DelayTypeId { get; set; }
	public double DelayEndTime { get; set; }
	public short ObjectGID { get; set; }

	public HumanOptionObjectUse() {}


	public HumanOptionObjectUse InitHumanOptionObjectUse(byte DelayTypeId, double DelayEndTime, short ObjectGID)
	{
		this.DelayTypeId = DelayTypeId;
		this.DelayEndTime = DelayEndTime;
		this.ObjectGID = ObjectGID;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.DelayTypeId);
		writer.WriteDouble(this.DelayEndTime);
		writer.WriteVarShort(this.ObjectGID);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.DelayTypeId = reader.ReadByte();
		this.DelayEndTime = reader.ReadDouble();
		this.ObjectGID = reader.ReadVarShort();
	}
}
}
