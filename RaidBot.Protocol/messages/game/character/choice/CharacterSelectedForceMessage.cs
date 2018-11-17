using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CharacterSelectedForceMessage : NetworkMessage
{

	public const uint Id = 6068;
	public override uint MessageId { get { return Id; } }

	public int Id_ { get; set; }

	public CharacterSelectedForceMessage() {}


	public CharacterSelectedForceMessage InitCharacterSelectedForceMessage(int Id_)
	{
		this.Id_ = Id_;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.Id_);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Id_ = reader.ReadInt();
	}
}
}
