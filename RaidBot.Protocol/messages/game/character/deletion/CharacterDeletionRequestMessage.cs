using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CharacterDeletionRequestMessage : NetworkMessage
{

	public const uint Id = 165;
	public override uint MessageId { get { return Id; } }

	public long CharacterId { get; set; }
	public String SecretAnswerHash { get; set; }

	public CharacterDeletionRequestMessage() {}


	public CharacterDeletionRequestMessage InitCharacterDeletionRequestMessage(long CharacterId, String SecretAnswerHash)
	{
		this.CharacterId = CharacterId;
		this.SecretAnswerHash = SecretAnswerHash;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.CharacterId);
		writer.WriteUTF(this.SecretAnswerHash);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.CharacterId = reader.ReadVarLong();
		this.SecretAnswerHash = reader.ReadUTF();
	}
}
}
