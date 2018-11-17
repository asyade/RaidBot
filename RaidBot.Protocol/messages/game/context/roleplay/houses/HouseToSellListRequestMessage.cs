using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HouseToSellListRequestMessage : NetworkMessage
{

	public const uint Id = 6139;
	public override uint MessageId { get { return Id; } }

	public short PageIndex { get; set; }

	public HouseToSellListRequestMessage() {}


	public HouseToSellListRequestMessage InitHouseToSellListRequestMessage(short PageIndex)
	{
		this.PageIndex = PageIndex;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.PageIndex);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.PageIndex = reader.ReadVarShort();
	}
}
}
