using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FightTeamMemberInformations : NetworkType
{

	public const uint Id = 44;
	public override uint MessageId { get { return Id; } }

	public double Id_ { get; set; }

	public FightTeamMemberInformations() {}


	public FightTeamMemberInformations InitFightTeamMemberInformations(double Id_)
	{
		this.Id_ = Id_;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.Id_);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Id_ = reader.ReadDouble();
	}
}
}
