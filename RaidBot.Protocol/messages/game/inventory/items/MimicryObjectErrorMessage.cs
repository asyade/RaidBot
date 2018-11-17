using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MimicryObjectErrorMessage : SymbioticObjectErrorMessage
{

	public const uint Id = 6461;
	public override uint MessageId { get { return Id; } }

	public bool Preview { get; set; }

	public MimicryObjectErrorMessage() {}


	public MimicryObjectErrorMessage InitMimicryObjectErrorMessage(bool Preview)
	{
		this.Preview = Preview;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteBoolean(this.Preview);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Preview = reader.ReadBoolean();
	}
}
}
