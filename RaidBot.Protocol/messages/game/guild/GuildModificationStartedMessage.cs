using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildModificationStartedMessage : NetworkMessage
{

	public const uint Id = 6324;
	public override uint MessageId { get { return Id; } }

	public bool CanChangeName { get; set; }
	public bool CanChangeEmblem { get; set; }

	public GuildModificationStartedMessage() {}


	public GuildModificationStartedMessage InitGuildModificationStartedMessage(bool CanChangeName, bool CanChangeEmblem)
	{
		this.CanChangeName = CanChangeName;
		this.CanChangeEmblem = CanChangeEmblem;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		byte box = 0;
		box = BooleanByteWrapper.SetFlag(box, 0, CanChangeName);
		box = BooleanByteWrapper.SetFlag(box, 1, CanChangeEmblem);
		writer.WriteByte(box);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		byte box = reader.ReadByte();
		this.CanChangeName = BooleanByteWrapper.GetFlag(box, 0);
		this.CanChangeEmblem = BooleanByteWrapper.GetFlag(box, 1);
	}
}
}
