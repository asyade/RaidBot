using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TaxCollectorDialogQuestionBasicMessage : NetworkMessage
{

	public const uint Id = 5619;
	public override uint MessageId { get { return Id; } }

	public BasicGuildInformations GuildInfo { get; set; }

	public TaxCollectorDialogQuestionBasicMessage() {}


	public TaxCollectorDialogQuestionBasicMessage InitTaxCollectorDialogQuestionBasicMessage(BasicGuildInformations GuildInfo)
	{
		this.GuildInfo = GuildInfo;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.GuildInfo.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.GuildInfo = new BasicGuildInformations();
		this.GuildInfo.Deserialize(reader);
	}
}
}
