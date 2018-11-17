using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CharacterSelectionWithRemodelMessage : CharacterSelectionMessage
{

	public const uint Id = 6549;
	public override uint MessageId { get { return Id; } }

	public RemodelingInformation Remodel { get; set; }

	public CharacterSelectionWithRemodelMessage() {}


	public CharacterSelectionWithRemodelMessage InitCharacterSelectionWithRemodelMessage(RemodelingInformation Remodel)
	{
		this.Remodel = Remodel;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		this.Remodel.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Remodel = new RemodelingInformation();
		this.Remodel.Deserialize(reader);
	}
}
}
