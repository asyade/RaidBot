using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightEntityInformation : GameFightFighterInformations
{

	public const uint Id = 551;
	public override uint MessageId { get { return Id; } }

	public byte EntityModelId { get; set; }
	public short Level { get; set; }
	public double MasterId { get; set; }

	public GameFightEntityInformation() {}


	public GameFightEntityInformation InitGameFightEntityInformation(byte EntityModelId, short Level, double MasterId)
	{
		this.EntityModelId = EntityModelId;
		this.Level = Level;
		this.MasterId = MasterId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.EntityModelId);
		writer.WriteVarShort(this.Level);
		writer.WriteDouble(this.MasterId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.EntityModelId = reader.ReadByte();
		this.Level = reader.ReadVarShort();
		this.MasterId = reader.ReadDouble();
	}
}
}
