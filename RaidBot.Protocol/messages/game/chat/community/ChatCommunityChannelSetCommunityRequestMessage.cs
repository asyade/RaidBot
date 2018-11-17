using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ChatCommunityChannelSetCommunityRequestMessage : NetworkMessage
{

	public const uint Id = 6729;
	public override uint MessageId { get { return Id; } }

	public short CommunityId { get; set; }

	public ChatCommunityChannelSetCommunityRequestMessage() {}


	public ChatCommunityChannelSetCommunityRequestMessage InitChatCommunityChannelSetCommunityRequestMessage(short CommunityId)
	{
		this.CommunityId = CommunityId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.CommunityId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.CommunityId = reader.ReadShort();
	}
}
}
