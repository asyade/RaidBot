using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameContextActorInformations : NetworkType
{

	public const uint Id = 150;
	public override uint MessageId { get { return Id; } }

	public double ContextualId { get; set; }
	public EntityLook Look { get; set; }

	public GameContextActorInformations() {}


	public GameContextActorInformations InitGameContextActorInformations(double ContextualId, EntityLook Look)
	{
		this.ContextualId = ContextualId;
		this.Look = Look;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.ContextualId);
		this.Look.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ContextualId = reader.ReadDouble();
		this.Look = new EntityLook();
		this.Look.Deserialize(reader);
	}
}
}
