using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayHumanoidInformations : GameRolePlayNamedActorInformations
{

	public const uint Id = 159;
	public override uint MessageId { get { return Id; } }

	public int AccountId { get; set; }

	public GameRolePlayHumanoidInformations() {}


	public GameRolePlayHumanoidInformations InitGameRolePlayHumanoidInformations(int AccountId)
	{
		this.AccountId = AccountId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteInt(this.AccountId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.AccountId = reader.ReadInt();
	}
}
}
