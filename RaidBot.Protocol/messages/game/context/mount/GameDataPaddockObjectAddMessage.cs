using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameDataPaddockObjectAddMessage : NetworkMessage
{

	public const uint Id = 5990;
	public override uint MessageId { get { return Id; } }

	public PaddockItem PaddockItemDescription { get; set; }

	public GameDataPaddockObjectAddMessage() {}


	public GameDataPaddockObjectAddMessage InitGameDataPaddockObjectAddMessage(PaddockItem PaddockItemDescription)
	{
		this.PaddockItemDescription = PaddockItemDescription;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.PaddockItemDescription.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.PaddockItemDescription = new PaddockItem();
		this.PaddockItemDescription.Deserialize(reader);
	}
}
}
