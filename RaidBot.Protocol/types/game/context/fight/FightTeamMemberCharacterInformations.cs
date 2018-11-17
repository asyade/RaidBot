using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FightTeamMemberCharacterInformations : FightTeamMemberInformations
{

	public const uint Id = 13;
	public override uint MessageId { get { return Id; } }

	public String Name { get; set; }
	public short Level { get; set; }

	public FightTeamMemberCharacterInformations() {}


	public FightTeamMemberCharacterInformations InitFightTeamMemberCharacterInformations(String Name, short Level)
	{
		this.Name = Name;
		this.Level = Level;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteUTF(this.Name);
		writer.WriteVarShort(this.Level);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Name = reader.ReadUTF();
		this.Level = reader.ReadVarShort();
	}
}
}
