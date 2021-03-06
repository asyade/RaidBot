using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class SymbioticObjectErrorMessage : ObjectErrorMessage
{

	public const uint Id = 6526;
	public override uint MessageId { get { return Id; } }

	public byte ErrorCode { get; set; }

	public SymbioticObjectErrorMessage() {}


	public SymbioticObjectErrorMessage InitSymbioticObjectErrorMessage(byte ErrorCode)
	{
		this.ErrorCode = ErrorCode;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.ErrorCode);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.ErrorCode = reader.ReadByte();
	}
}
}
