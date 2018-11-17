using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HumanOptionTitle : HumanOption
{

	public const uint Id = 408;
	public override uint MessageId { get { return Id; } }

	public short TitleId { get; set; }
	public String TitleParam { get; set; }

	public HumanOptionTitle() {}


	public HumanOptionTitle InitHumanOptionTitle(short TitleId, String TitleParam)
	{
		this.TitleId = TitleId;
		this.TitleParam = TitleParam;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.TitleId);
		writer.WriteUTF(this.TitleParam);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.TitleId = reader.ReadVarShort();
		this.TitleParam = reader.ReadUTF();
	}
}
}
