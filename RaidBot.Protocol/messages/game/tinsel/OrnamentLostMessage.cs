using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class OrnamentLostMessage : NetworkMessage
{

	public const uint Id = 6770;
	public override uint MessageId { get { return Id; } }

	public short OrnamentId { get; set; }

	public OrnamentLostMessage() {}


	public OrnamentLostMessage InitOrnamentLostMessage(short OrnamentId)
	{
		this.OrnamentId = OrnamentId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.OrnamentId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.OrnamentId = reader.ReadShort();
	}
}
}
