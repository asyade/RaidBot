using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AllianceKickRequestMessage : NetworkMessage
{

	public const uint Id = 6400;
	public override uint MessageId { get { return Id; } }

	public int KickedId { get; set; }

	public AllianceKickRequestMessage() {}


	public AllianceKickRequestMessage InitAllianceKickRequestMessage(int KickedId)
	{
		this.KickedId = KickedId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.KickedId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.KickedId = reader.ReadVarInt();
	}
}
}
