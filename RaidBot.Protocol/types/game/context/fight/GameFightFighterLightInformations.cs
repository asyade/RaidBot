using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightFighterLightInformations : NetworkType
{

	public const uint Id = 413;
	public override uint MessageId { get { return Id; } }

	public bool Sex { get; set; }
	public bool Alive { get; set; }
	public double Id_ { get; set; }
	public byte Wave { get; set; }
	public short Level { get; set; }
	public byte Breed { get; set; }

	public GameFightFighterLightInformations() {}


	public GameFightFighterLightInformations InitGameFightFighterLightInformations(bool Sex, bool Alive, double Id_, byte Wave, short Level, byte Breed)
	{
		this.Sex = Sex;
		this.Alive = Alive;
		this.Id_ = Id_;
		this.Wave = Wave;
		this.Level = Level;
		this.Breed = Breed;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		byte box = 0;
		box = BooleanByteWrapper.SetFlag(box, 0, Sex);
		box = BooleanByteWrapper.SetFlag(box, 1, Alive);
		writer.WriteByte(box);
		writer.WriteDouble(this.Id_);
		writer.WriteByte(this.Wave);
		writer.WriteVarShort(this.Level);
		writer.WriteByte(this.Breed);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		byte box = reader.ReadByte();
		this.Sex = BooleanByteWrapper.GetFlag(box, 0);
		this.Alive = BooleanByteWrapper.GetFlag(box, 1);
		this.Id_ = reader.ReadDouble();
		this.Wave = reader.ReadByte();
		this.Level = reader.ReadVarShort();
		this.Breed = reader.ReadByte();
	}
}
}
