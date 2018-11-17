using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AccountHouseMessage : NetworkMessage
{

	public const uint Id = 6315;
	public override uint MessageId { get { return Id; } }

	public AccountHouseInformations[] Houses { get; set; }

	public AccountHouseMessage() {}


	public AccountHouseMessage InitAccountHouseMessage(AccountHouseInformations[] Houses)
	{
		this.Houses = Houses;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.Houses.Length);
		foreach (AccountHouseInformations item in this.Houses)
		{
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		int HousesLen = reader.ReadShort();
		Houses = new AccountHouseInformations[HousesLen];
		for (int i = 0; i < HousesLen; i++)
		{
			this.Houses[i] = new AccountHouseInformations();
			this.Houses[i].Deserialize(reader);
		}
	}
}
}
