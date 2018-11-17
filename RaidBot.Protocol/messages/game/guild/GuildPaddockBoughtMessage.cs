using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildPaddockBoughtMessage : NetworkMessage
{

	public const uint Id = 5952;
	public override uint MessageId { get { return Id; } }

	public PaddockContentInformations PaddockInfo { get; set; }

	public GuildPaddockBoughtMessage() {}


	public GuildPaddockBoughtMessage InitGuildPaddockBoughtMessage(PaddockContentInformations PaddockInfo)
	{
		this.PaddockInfo = PaddockInfo;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.PaddockInfo.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.PaddockInfo = new PaddockContentInformations();
		this.PaddockInfo.Deserialize(reader);
	}
}
}
