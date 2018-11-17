using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class OrnamentSelectRequestMessage : NetworkMessage
{

	public const uint Id = 6374;
	public override uint MessageId { get { return Id; } }

	public short OrnamentId { get; set; }

	public OrnamentSelectRequestMessage() {}


	public OrnamentSelectRequestMessage InitOrnamentSelectRequestMessage(short OrnamentId)
	{
		this.OrnamentId = OrnamentId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.OrnamentId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.OrnamentId = reader.ReadVarShort();
	}
}
}
