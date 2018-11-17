using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PrismInfoJoinLeaveRequestMessage : NetworkMessage
{

	public const uint Id = 5844;
	public override uint MessageId { get { return Id; } }

	public bool Join { get; set; }

	public PrismInfoJoinLeaveRequestMessage() {}


	public PrismInfoJoinLeaveRequestMessage InitPrismInfoJoinLeaveRequestMessage(bool Join)
	{
		this.Join = Join;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.Join);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Join = reader.ReadBoolean();
	}
}
}
