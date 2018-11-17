using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ActorAlignmentInformations : NetworkType
{

	public const uint Id = 201;
	public override uint MessageId { get { return Id; } }

	public byte AlignmentSide { get; set; }
	public byte AlignmentValue { get; set; }
	public byte AlignmentGrade { get; set; }
	public double CharacterPower { get; set; }

	public ActorAlignmentInformations() {}


	public ActorAlignmentInformations InitActorAlignmentInformations(byte AlignmentSide, byte AlignmentValue, byte AlignmentGrade, double CharacterPower)
	{
		this.AlignmentSide = AlignmentSide;
		this.AlignmentValue = AlignmentValue;
		this.AlignmentGrade = AlignmentGrade;
		this.CharacterPower = CharacterPower;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.AlignmentSide);
		writer.WriteByte(this.AlignmentValue);
		writer.WriteByte(this.AlignmentGrade);
		writer.WriteDouble(this.CharacterPower);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.AlignmentSide = reader.ReadByte();
		this.AlignmentValue = reader.ReadByte();
		this.AlignmentGrade = reader.ReadByte();
		this.CharacterPower = reader.ReadDouble();
	}
}
}
