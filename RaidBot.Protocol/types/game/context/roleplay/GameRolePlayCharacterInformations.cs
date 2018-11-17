using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayCharacterInformations : GameRolePlayHumanoidInformations
{

	public const uint Id = 36;
	public override uint MessageId { get { return Id; } }

	public ActorAlignmentInformations AlignmentInfos { get; set; }

	public GameRolePlayCharacterInformations() {}


	public GameRolePlayCharacterInformations InitGameRolePlayCharacterInformations(ActorAlignmentInformations AlignmentInfos)
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
