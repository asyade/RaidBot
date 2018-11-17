using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildInvitationMessage : NetworkMessage
{

	public const uint Id = 5551;
	public override uint MessageId { get { return Id; } }

	public long TargetId { get; set; }

	public GuildInvitationMessage() {}


	public GuildInvitationMessage InitGuildInvitationMessage(long TargetId)
	{
		this.TargetId = TargetId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.TargetId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.TargetId = reader.ReadVarLong();
	}
}
}
