using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightFighterInformations : GameContextActorInformations
{

	public const uint Id = 143;
	public override uint MessageId { get { return Id; } }

	public byte TeamId { get; set; }
	public byte Wave { get; set; }
	public bool Alive { get; set; }
	public short[] PreviousPositions { get; set; }

	public GameFightFighterInformations() {}


	public GameFightFighterInformations InitGameFightFighterInformations(byte TeamId, byte Wave, bool Alive, short[] PreviousPositions)
	{
		this.TeamId = TeamId;
		this.Wave = Wave;
		this.Alive = Alive;
		this.PreviousPositions = PreviousPositions;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.TeamId);
		writer.WriteByte(this.Wave);
		writer.WriteBoolean(this.Alive);
		writer.WriteShort(this.PreviousPositions.Length);
		foreach (short item in this.PreviousPositions)
		{
			writer.WriteVarShort(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.TeamId = reader.ReadByte();
		this.Wave = reader.ReadByte();
		this.Alive = reader.ReadBoolean();
		int PreviousPositionsLen = reader.ReadShort();
		PreviousPositions = new short[PreviousPositionsLen];
		for (int i = 0; i < PreviousPositionsLen; i++)
		{
			this.PreviousPositions[i] = reader.ReadVarShort();
		}
	}
}
}
