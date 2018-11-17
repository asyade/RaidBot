using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ServerSessionConstant : NetworkType
{

	public const uint Id = 430;
	public override uint MessageId { get { return Id; } }

	public short Id_ { get; set; }

	public ServerSessionConstant() {}


	public ServerSessionConstant InitServerSessionConstant(short Id_)
	{
		this.Id_ = Id_;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.Id_);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Id_ = reader.ReadVarShort();
	}
}
}
