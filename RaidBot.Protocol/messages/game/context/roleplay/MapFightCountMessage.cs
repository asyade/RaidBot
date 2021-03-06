using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MapFightCountMessage : NetworkMessage
{

	public const uint Id = 210;
	public override uint MessageId { get { return Id; } }

	public short FightCount { get; set; }

	public MapFightCountMessage() {}


	public MapFightCountMessage InitMapFightCountMessage(short FightCount)
	{
		this.FightCount = FightCount;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.FightCount);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.FightCount = reader.ReadVarShort();
	}
}
}
