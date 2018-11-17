using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyFollowStatusUpdateMessage : AbstractPartyMessage
{

	public const uint Id = 5581;
	public override uint MessageId { get { return Id; } }

	public bool Success { get; set; }
	public bool IsFollowed { get; set; }
	public long FollowedId { get; set; }

	public PartyFollowStatusUpdateMessage() {}


	public PartyFollowStatusUpdateMessage InitPartyFollowStatusUpdateMessage(bool Success, bool IsFollowed, long FollowedId)
	{
		this.Success = Success;
		this.IsFollowed = IsFollowed;
		this.FollowedId = FollowedId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		byte box = 0;
		box = BooleanByteWrapper.SetFlag(box, 0, Success);
		box = BooleanByteWrapper.SetFlag(box, 1, IsFollowed);
		writer.WriteByte(box);
		writer.WriteVarLong(this.FollowedId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		byte box = reader.ReadByte();
		this.Success = BooleanByteWrapper.GetFlag(box, 0);
		this.IsFollowed = BooleanByteWrapper.GetFlag(box, 1);
		this.FollowedId = reader.ReadVarLong();
	}
}
}
