using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightFighterEntityLightInformation : GameFightFighterLightInformations
{

	public const uint Id = 548;
	public override uint MessageId { get { return Id; } }

	public byte EntityModelId { get; set; }
	public double MasterId { get; set; }

	public GameFightFighterEntityLightInformation() {}


	public GameFightFighterEntityLightInformation InitGameFightFighterEntityLightInformation(byte EntityModelId, double MasterId)
	{
		this.EntityModelId = EntityModelId;
		this.MasterId = MasterId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.EntityModelId);
		writer.WriteDouble(this.MasterId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.EntityModelId = reader.ReadByte();
		this.MasterId = reader.ReadDouble();
	}
}
}
