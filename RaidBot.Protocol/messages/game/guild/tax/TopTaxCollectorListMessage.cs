using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TopTaxCollectorListMessage : AbstractTaxCollectorListMessage
{

	public const uint Id = 6565;
	public override uint MessageId { get { return Id; } }

	public bool IsDungeon { get; set; }

	public TopTaxCollectorListMessage() {}


	public TopTaxCollectorListMessage InitTopTaxCollectorListMessage(bool IsDungeon)
	{
		this.IsDungeon = IsDungeon;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteBoolean(this.IsDungeon);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.IsDungeon = reader.ReadBoolean();
	}
}
}
