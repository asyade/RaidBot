using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HouseKickIndoorMerchantRequestMessage : NetworkMessage
{

	public const uint Id = 5661;
	public override uint MessageId { get { return Id; } }

	public short CellId { get; set; }

	public HouseKickIndoorMerchantRequestMessage() {}


	public HouseKickIndoorMerchantRequestMessage InitHouseKickIndoorMerchantRequestMessage(short CellId)
	{
		this.CellId = CellId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.CellId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.CellId = reader.ReadVarShort();
	}
}
}
