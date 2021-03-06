using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightCharacterInformations : GameFightFighterNamedInformations
{

	public const uint Id = 46;
	public override uint MessageId { get { return Id; } }

	public short Level { get; set; }
	public ActorAlignmentInformations AlignmentInfos { get; set; }
	public byte Breed { get; set; }
	public bool Sex { get; set; }

	public GameFightCharacterInformations() {}


	public GameFightCharacterInformations InitGameFightCharacterInformations(short Level, ActorAlignmentInformations AlignmentInfos, byte Breed, bool Sex)
	{
		this.Level = Level;
		this.AlignmentInfos = AlignmentInfos;
		this.Breed = Breed;
		this.Sex = Sex;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.Level);
		this.AlignmentInfos.Serialize(writer);
		writer.WriteByte(this.Breed);
		writer.WriteBoolean(this.Sex);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Level = reader.ReadVarShort();
		this.AlignmentInfos = new ActorAlignmentInformations();
		this.AlignmentInfos.Deserialize(reader);
		this.Breed = reader.ReadByte();
		this.Sex = reader.ReadBoolean();
	}
}
}
