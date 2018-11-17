using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FriendDeleteRequestMessage : NetworkMessage
{

	public const uint Id = 5603;
	public override uint MessageId { get { return Id; } }

	public int AccountId { get; set; }

	public FriendDeleteRequestMessage() {}


	public FriendDeleteRequestMessage InitFriendDeleteRequestMessage(int AccountId)
	{
		this.AccountId = AccountId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.AccountId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.AccountId = reader.ReadInt();
	}
}
}
