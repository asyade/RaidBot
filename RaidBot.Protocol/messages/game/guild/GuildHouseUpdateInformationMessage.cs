using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildHouseUpdateInformationMessage : NetworkMessage
{

	public const uint Id = 6181;
	public override uint MessageId { get { return Id; } }

	public HouseInformationsForGuild HousesInformations { get; set; }

	public GuildHouseUpdateInformationMessage() {}


	public GuildHouseUpdateInformationMessage InitGuildHouseUpdateInformationMessage(HouseInformationsForGuild HousesInformations)
	{
		this.HousesInformations = HousesInformations;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.HousesInformations.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.HousesInformations = new HouseInformationsForGuild();
		this.HousesInformations.Deserialize(reader);
	}
}
}
