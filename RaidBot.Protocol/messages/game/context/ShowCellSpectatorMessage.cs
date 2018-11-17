using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ShowCellSpectatorMessage : ShowCellMessage
{

	public const uint Id = 6158;
	public override uint MessageId { get { return Id; } }

	public String PlayerName { get; set; }

	public ShowCellSpectatorMessage() {}


	public ShowCellSpectatorMessage InitShowCellSpectatorMessage(String PlayerName)
	{
		this.PlayerName = PlayerName;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteUTF(this.PlayerName);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.PlayerName = reader.ReadUTF();
	}
}
}
