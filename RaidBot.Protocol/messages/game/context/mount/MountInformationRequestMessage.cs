using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MountInformationRequestMessage : NetworkMessage
{

	public const uint Id = 5972;
	public override uint MessageId { get { return Id; } }

	public double Id_ { get; set; }
	public double Time { get; set; }

	public MountInformationRequestMessage() {}


	public MountInformationRequestMessage InitMountInformationRequestMessage(double Id_, double Time)
	{
		this.Id_ = Id_;
		this.Time = Time;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.Id_);
		writer.WriteDouble(this.Time);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Id_ = reader.ReadDouble();
		this.Time = reader.ReadDouble();
	}
}
}
