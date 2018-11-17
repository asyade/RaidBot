using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ChangeThemeRequestMessage : NetworkMessage
{

	public const uint Id = 6639;
	public override uint MessageId { get { return Id; } }

	public byte Theme { get; set; }

	public ChangeThemeRequestMessage() {}


	public ChangeThemeRequestMessage InitChangeThemeRequestMessage(byte Theme)
	{
		this.Theme = Theme;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.Theme);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Theme = reader.ReadByte();
	}
}
}
