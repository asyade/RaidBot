using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class IdentifiedEntityDispositionInformations : EntityDispositionInformations
{

	public const uint Id = 107;
	public override uint MessageId { get { return Id; } }

	public double Id_ { get; set; }

	public IdentifiedEntityDispositionInformations() {}


	public IdentifiedEntityDispositionInformations InitIdentifiedEntityDispositionInformations(double Id_)
	{
		this.Id_ = Id_;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteDouble(this.Id_);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Id_ = reader.ReadDouble();
	}
}
}
