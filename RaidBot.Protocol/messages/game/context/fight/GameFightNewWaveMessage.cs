using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightNewWaveMessage : NetworkMessage
{

	public const uint Id = 6490;
	public override uint MessageId { get { return Id; } }

	public byte Id_ { get; set; }
	public byte TeamId { get; set; }
	public short NbTurnBeforeNextWave { get; set; }

	public GameFightNewWaveMessage() {}


	public GameFightNewWaveMessage InitGameFightNewWaveMessage(byte Id_, byte TeamId, short NbTurnBeforeNextWave)
	{
		this.Id_ = Id_;
		this.TeamId = TeamId;
		this.NbTurnBeforeNextWave = NbTurnBeforeNextWave;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.Id_);
		writer.WriteByte(this.TeamId);
		writer.WriteShort(this.NbTurnBeforeNextWave);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Id_ = reader.ReadByte();
		this.TeamId = reader.ReadByte();
		this.NbTurnBeforeNextWave = reader.ReadShort();
	}
}
}
