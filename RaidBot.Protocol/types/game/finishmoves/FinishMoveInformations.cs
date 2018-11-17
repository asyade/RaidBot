using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FinishMoveInformations : NetworkType
{

	public const uint Id = 506;
	public override uint MessageId { get { return Id; } }

	public int FinishMoveId { get; set; }
	public bool FinishMoveState { get; set; }

	public FinishMoveInformations() {}


	public FinishMoveInformations InitFinishMoveInformations(int FinishMoveId, bool FinishMoveState)
	{
		this.FinishMoveId = FinishMoveId;
		this.FinishMoveState = FinishMoveState;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.FinishMoveId);
		writer.WriteBoolean(this.FinishMoveState);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.FinishMoveId = reader.ReadInt();
		this.FinishMoveState = reader.ReadBoolean();
	}
}
}
