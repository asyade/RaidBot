using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ServerSessionConstantString : ServerSessionConstant
{

	public const uint Id = 436;
	public override uint MessageId { get { return Id; } }

	public String Value { get; set; }

	public ServerSessionConstantString() {}


	public ServerSessionConstantString InitServerSessionConstantString(String Value)
	{
		this.Value = Value;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteUTF(this.Value);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Value = reader.ReadUTF();
	}
}
}
