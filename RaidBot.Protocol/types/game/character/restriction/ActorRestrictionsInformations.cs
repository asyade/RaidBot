using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ActorRestrictionsInformations : NetworkType
{

	public const uint Id = 204;
	public override uint MessageId { get { return Id; } }

	public bool CantBeAggressed { get; set; }
	public bool CantBeChallenged { get; set; }
	public bool CantTrade { get; set; }
	public bool CantBeAttackedByMutant { get; set; }
	public bool CantRun { get; set; }
	public bool ForceSlowWalk { get; set; }
	public bool CantMinimize { get; set; }
	public bool CantMove { get; set; }

	public ActorRestrictionsInformations() {}


	public ActorRestrictionsInformations InitActorRestrictionsInformations(bool CantBeAggressed, bool CantBeChallenged, bool CantTrade, bool CantBeAttackedByMutant, bool CantRun, bool ForceSlowWalk, bool CantMinimize, bool CantMove)
	{
		this.CantBeAggressed = CantBeAggressed;
		this.CantBeChallenged = CantBeChallenged;
		this.CantTrade = CantTrade;
		this.CantBeAttackedByMutant = CantBeAttackedByMutant;
		this.CantRun = CantRun;
		this.ForceSlowWalk = ForceSlowWalk;
		this.CantMinimize = CantMinimize;
		this.CantMove = CantMove;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		byte box = 0;
		box = BooleanByteWrapper.SetFlag(box, 0, CantBeAggressed);
		box = BooleanByteWrapper.SetFlag(box, 1, CantBeChallenged);
		box = BooleanByteWrapper.SetFlag(box, 2, CantTrade);
		box = BooleanByteWrapper.SetFlag(box, 3, CantBeAttackedByMutant);
		box = BooleanByteWrapper.SetFlag(box, 4, CantRun);
		box = BooleanByteWrapper.SetFlag(box, 5, ForceSlowWalk);
		box = BooleanByteWrapper.SetFlag(box, 6, CantMinimize);
		box = BooleanByteWrapper.SetFlag(box, 7, CantMove);
		writer.WriteByte(box);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		byte box = reader.ReadByte();
		this.CantBeAggressed = BooleanByteWrapper.GetFlag(box, 0);
		this.CantBeChallenged = BooleanByteWrapper.GetFlag(box, 1);
		this.CantTrade = BooleanByteWrapper.GetFlag(box, 2);
		this.CantBeAttackedByMutant = BooleanByteWrapper.GetFlag(box, 3);
		this.CantRun = BooleanByteWrapper.GetFlag(box, 4);
		this.ForceSlowWalk = BooleanByteWrapper.GetFlag(box, 5);
		this.CantMinimize = BooleanByteWrapper.GetFlag(box, 6);
		this.CantMove = BooleanByteWrapper.GetFlag(box, 7);
	}
}
}
