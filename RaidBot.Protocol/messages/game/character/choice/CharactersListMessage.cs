using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CharactersListMessage : BasicCharactersListMessage
{

	public const uint Id = 151;
	public override uint MessageId { get { return Id; } }

	public bool HasStartupActions { get; set; }

	public CharactersListMessage() {}


	public CharactersListMessage InitCharactersListMessage(bool HasStartupActions)
	{
		this.HasStartupActions = HasStartupActions;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteBoolean(this.HasStartupActions);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.HasStartupActions = reader.ReadBoolean();
	}
}
}
