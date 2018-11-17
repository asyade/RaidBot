using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class BulletinMessage : SocialNoticeMessage
{

	public const uint Id = 6695;
	public override uint MessageId { get { return Id; } }

	public int LastNotifiedTimestamp { get; set; }

	public BulletinMessage() {}


	public BulletinMessage InitBulletinMessage(int LastNotifiedTimestamp)
	{
		this.LastNotifiedTimestamp = LastNotifiedTimestamp;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteInt(this.LastNotifiedTimestamp);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.LastNotifiedTimestamp = reader.ReadInt();
	}
}
}
