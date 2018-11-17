using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AbstractContactInformations : NetworkType
{

	public const uint Id = 380;
	public override uint MessageId { get { return Id; } }

	public int AccountId { get; set; }
	public String AccountName { get; set; }

	public AbstractContactInformations() {}


	public AbstractContactInformations InitAbstractContactInformations(int AccountId, String AccountName)
	{
		this.AccountId = AccountId;
		this.AccountName = AccountName;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.AccountId);
		writer.WriteUTF(this.AccountName);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.AccountId = reader.ReadInt();
		this.AccountName = reader.ReadUTF();
	}
}
}
