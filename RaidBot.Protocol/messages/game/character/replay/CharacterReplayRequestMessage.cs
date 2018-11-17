using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CharacterReplayRequestMessage : NetworkMessage
{

	public const uint Id = 167;
	public override uint MessageId { get { return Id; } }

	public long CharacterId { get; set; }

	public CharacterReplayRequestMessage() {}


	public CharacterReplayRequestMessage InitCharacterReplayRequestMessage(long CharacterId)
	{
		this.CharacterId = CharacterId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.CharacterId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.CharacterId = reader.ReadVarLong();
	}
}
}
