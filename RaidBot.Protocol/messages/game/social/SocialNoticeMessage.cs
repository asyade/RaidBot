using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class SocialNoticeMessage : NetworkMessage
{

	public const uint Id = 6688;
	public override uint MessageId { get { return Id; } }

	public String Content { get; set; }
	public int Timestamp { get; set; }
	public long MemberId { get; set; }
	public String MemberName { get; set; }

	public SocialNoticeMessage() {}


	public SocialNoticeMessage InitSocialNoticeMessage(String Content, int Timestamp, long MemberId, String MemberName)
	{
		this.Content = Content;
		this.Timestamp = Timestamp;
		this.MemberId = MemberId;
		this.MemberName = MemberName;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.Content);
		writer.WriteInt(this.Timestamp);
		writer.WriteVarLong(this.MemberId);
		writer.WriteUTF(this.MemberName);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Content = reader.ReadUTF();
		this.Timestamp = reader.ReadInt();
		this.MemberId = reader.ReadVarLong();
		this.MemberName = reader.ReadUTF();
	}
}
}
