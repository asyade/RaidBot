using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AlmanachCalendarDateMessage : NetworkMessage
{

	public const uint Id = 6341;
	public override uint MessageId { get { return Id; } }

	public int Date { get; set; }

	public AlmanachCalendarDateMessage() {}


	public AlmanachCalendarDateMessage InitAlmanachCalendarDateMessage(int Date)
	{
		this.Date = Date;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.Date);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Date = reader.ReadInt();
	}
}
}
