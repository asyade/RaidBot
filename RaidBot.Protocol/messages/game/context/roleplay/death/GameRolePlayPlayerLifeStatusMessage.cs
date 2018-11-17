using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayPlayerLifeStatusMessage : NetworkMessage
{

	public const uint Id = 5996;
	public override uint MessageId { get { return Id; } }

	public byte State { get; set; }
	public double PhenixMapId { get; set; }

	public GameRolePlayPlayerLifeStatusMessage() {}


	public GameRolePlayPlayerLifeStatusMessage InitGameRolePlayPlayerLifeStatusMessage(byte State, double PhenixMapId)
	{
		this.State = State;
		this.PhenixMapId = PhenixMapId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.State);
		writer.WriteDouble(this.PhenixMapId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.State = reader.ReadByte();
		this.PhenixMapId = reader.ReadDouble();
	}
}
}
