using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AllianceBulletinSetRequestMessage : SocialNoticeSetRequestMessage
{

	public const uint Id = 6693;
	public override uint MessageId { get { return Id; } }

	public String Content { get; set; }
	public bool NotifyMembers { get; set; }

	public AllianceBulletinSetRequestMessage() {}


	public AllianceBulletinSetRequestMessage InitAllianceBulletinSetRequestMessage(String Content, bool NotifyMembers)
	{
		this.Content = Content;
		this.NotifyMembers = NotifyMembers;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteUTF(this.Content);
		writer.WriteBoolean(this.NotifyMembers);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Content = reader.ReadUTF();
		this.NotifyMembers = reader.ReadBoolean();
	}
}
}
