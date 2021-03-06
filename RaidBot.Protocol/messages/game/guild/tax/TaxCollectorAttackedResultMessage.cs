using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TaxCollectorAttackedResultMessage : NetworkMessage
{

	public const uint Id = 5635;
	public override uint MessageId { get { return Id; } }

	public bool DeadOrAlive { get; set; }
	public TaxCollectorBasicInformations BasicInfos { get; set; }
	public BasicGuildInformations Guild { get; set; }

	public TaxCollectorAttackedResultMessage() {}


	public TaxCollectorAttackedResultMessage InitTaxCollectorAttackedResultMessage(bool DeadOrAlive, TaxCollectorBasicInformations BasicInfos, BasicGuildInformations Guild)
	{
		this.DeadOrAlive = DeadOrAlive;
		this.BasicInfos = BasicInfos;
		this.Guild = Guild;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.DeadOrAlive);
		this.BasicInfos.Serialize(writer);
		this.Guild.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.DeadOrAlive = reader.ReadBoolean();
		this.BasicInfos = new TaxCollectorBasicInformations();
		this.BasicInfos.Deserialize(reader);
		this.Guild = new BasicGuildInformations();
		this.Guild.Deserialize(reader);
	}
}
}
