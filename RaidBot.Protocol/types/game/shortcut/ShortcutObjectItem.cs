using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ShortcutObjectItem : ShortcutObject
{

	public const uint Id = 371;
	public override uint MessageId { get { return Id; } }

	public int ItemUID { get; set; }
	public int ItemGID { get; set; }

	public ShortcutObjectItem() {}


	public ShortcutObjectItem InitShortcutObjectItem(int ItemUID, int ItemGID)
	{
		this.ItemUID = ItemUID;
		this.ItemGID = ItemGID;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteInt(this.ItemUID);
		writer.WriteInt(this.ItemGID);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.ItemUID = reader.ReadInt();
		this.ItemGID = reader.ReadInt();
	}
}
}
