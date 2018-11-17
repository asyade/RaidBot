using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameContextRefreshEntityLookMessage : NetworkMessage
{

	public const uint Id = 5637;
	public override uint MessageId { get { return Id; } }

	public double Id_ { get; set; }
	public EntityLook Look { get; set; }

	public GameContextRefreshEntityLookMessage() {}


	public GameContextRefreshEntityLookMessage InitGameContextRefreshEntityLookMessage(double Id_, EntityLook Look)
	{
		this.Id_ = Id_;
		this.Look = Look;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.Id_);
		this.Look.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Id_ = reader.ReadDouble();
		this.Look = new EntityLook();
		this.Look.Deserialize(reader);
	}
}
}
