using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ActorExtendedAlignmentInformations : ActorAlignmentInformations
{

	public const uint Id = 202;
	public override uint MessageId { get { return Id; } }

	public short Honor { get; set; }
	public short HonorGradeFloor { get; set; }
	public short HonorNextGradeFloor { get; set; }
	public byte Aggressable { get; set; }

	public ActorExtendedAlignmentInformations() {}


	public ActorExtendedAlignmentInformations InitActorExtendedAlignmentInformations(short Honor, short HonorGradeFloor, short HonorNextGradeFloor, byte Aggressable)
	{
		this.Honor = Honor;
		this.HonorGradeFloor = HonorGradeFloor;
		this.HonorNextGradeFloor = HonorNextGradeFloor;
		this.Aggressable = Aggressable;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.Honor);
		writer.WriteVarShort(this.HonorGradeFloor);
		writer.WriteVarShort(this.HonorNextGradeFloor);
		writer.WriteByte(this.Aggressable);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Honor = reader.ReadVarShort();
		this.HonorGradeFloor = reader.ReadVarShort();
		this.HonorNextGradeFloor = reader.ReadVarShort();
		this.Aggressable = reader.ReadByte();
	}
}
}
