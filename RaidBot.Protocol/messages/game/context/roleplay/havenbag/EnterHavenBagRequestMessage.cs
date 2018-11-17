using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class EnterHavenBagRequestMessage : NetworkMessage
{

	public const uint Id = 6636;
	public override uint MessageId { get { return Id; } }

	public long HavenBagOwner { get; set; }

	public EnterHavenBagRequestMessage() {}


	public EnterHavenBagRequestMessage InitEnterHavenBagRequestMessage(long HavenBagOwner)
	{
		this.HavenBagOwner = HavenBagOwner;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.HavenBagOwner);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.HavenBagOwner = reader.ReadVarLong();
	}
}
}
