using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FightExternalInformations : NetworkType
{

	public const uint Id = 117;
	public override uint MessageId { get { return Id; } }

	public short FightId { get; set; }
	public byte FightType { get; set; }
	public int FightStart { get; set; }
	public bool FightSpectatorLocked { get; set; }

	public FightExternalInformations() {}


	public FightExternalInformations InitFightExternalInformations(short FightId, byte FightType, int FightStart, bool FightSpectatorLocked)
	{
		this.FightId = FightId;
		this.FightType = FightType;
		this.FightStart = FightStart;
		this.FightSpectatorLocked = FightSpectatorLocked;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.FightId);
		writer.WriteByte(this.FightType);
		writer.WriteInt(this.FightStart);
		writer.WriteBoolean(this.FightSpectatorLocked);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.FightId = reader.ReadVarShort();
		this.FightType = reader.ReadByte();
		this.FightStart = reader.ReadInt();
		this.FightSpectatorLocked = reader.ReadBoolean();
	}
}
}
