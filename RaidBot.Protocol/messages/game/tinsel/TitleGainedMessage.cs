using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TitleGainedMessage : NetworkMessage
{

	public const uint Id = 6364;
	public override uint MessageId { get { return Id; } }

	public short TitleId { get; set; }

	public TitleGainedMessage() {}


	public TitleGainedMessage InitTitleGainedMessage(short TitleId)
	{
		this.TitleId = TitleId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.TitleId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.TitleId = reader.ReadVarShort();
	}
}
}
