using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CharacterCanBeCreatedResultMessage : NetworkMessage
{

	public const uint Id = 6733;
	public override uint MessageId { get { return Id; } }

	public bool YesYouCan { get; set; }

	public CharacterCanBeCreatedResultMessage() {}


	public CharacterCanBeCreatedResultMessage InitCharacterCanBeCreatedResultMessage(bool YesYouCan)
	{
		this.YesYouCan = YesYouCan;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.YesYouCan);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.YesYouCan = reader.ReadBoolean();
	}
}
}
