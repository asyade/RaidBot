using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightMonsterWithAlignmentInformations : GameFightMonsterInformations
{

	public const uint Id = 203;
	public override uint MessageId { get { return Id; } }

	public ActorAlignmentInformations AlignmentInfos { get; set; }

	public GameFightMonsterWithAlignmentInformations() {}


	public GameFightMonsterWithAlignmentInformations InitGameFightMonsterWithAlignmentInformations(ActorAlignmentInformations AlignmentInfos)
	{
		this.AlignmentInfos = AlignmentInfos;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		this.AlignmentInfos.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.AlignmentInfos = new ActorAlignmentInformations();
		this.AlignmentInfos.Deserialize(reader);
	}
}
}
