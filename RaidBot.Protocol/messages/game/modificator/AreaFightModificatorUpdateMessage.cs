using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AreaFightModificatorUpdateMessage : NetworkMessage
{

	public const uint Id = 6493;
	public override uint MessageId { get { return Id; } }

	public int SpellPairId { get; set; }

	public AreaFightModificatorUpdateMessage() {}


	public AreaFightModificatorUpdateMessage InitAreaFightModificatorUpdateMessage(int SpellPairId)
	{
		this.SpellPairId = SpellPairId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.SpellPairId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SpellPairId = reader.ReadInt();
	}
}
}
