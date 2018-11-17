using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyNameSetErrorMessage : AbstractPartyMessage
{

	public const uint Id = 6501;
	public override uint MessageId { get { return Id; } }

	public byte Result { get; set; }

	public PartyNameSetErrorMessage() {}


	public PartyNameSetErrorMessage InitPartyNameSetErrorMessage(byte Result)
	{
		this.Result = Result;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.Result);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Result = reader.ReadByte();
	}
}
}
