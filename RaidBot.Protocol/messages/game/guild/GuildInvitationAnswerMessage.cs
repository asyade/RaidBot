using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildInvitationAnswerMessage : NetworkMessage
{

	public const uint Id = 5556;
	public override uint MessageId { get { return Id; } }

	public bool Accept { get; set; }

	public GuildInvitationAnswerMessage() {}


	public GuildInvitationAnswerMessage InitGuildInvitationAnswerMessage(bool Accept)
	{
		this.Accept = Accept;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.Accept);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Accept = reader.ReadBoolean();
	}
}
}
