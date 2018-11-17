using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HouseKickRequestMessage : NetworkMessage
{

	public const uint Id = 5698;
	public override uint MessageId { get { return Id; } }

	public long Id_ { get; set; }

	public HouseKickRequestMessage() {}


	public HouseKickRequestMessage InitHouseKickRequestMessage(long Id_)
	{
		this.Id_ = Id_;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.Id_);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Id_ = reader.ReadVarLong();
	}
}
}
