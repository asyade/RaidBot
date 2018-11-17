using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildMemberOnlineStatusMessage : NetworkMessage
{

	public const uint Id = 6061;
	public override uint MessageId { get { return Id; } }

	public long MemberId { get; set; }
	public bool Online { get; set; }

	public GuildMemberOnlineStatusMessage() {}


	public GuildMemberOnlineStatusMessage InitGuildMemberOnlineStatusMessage(long MemberId, bool Online)
	{
		this.MemberId = MemberId;
		this.Online = Online;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.MemberId);
		writer.WriteBoolean(this.Online);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MemberId = reader.ReadVarLong();
		this.Online = reader.ReadBoolean();
	}
}
}
