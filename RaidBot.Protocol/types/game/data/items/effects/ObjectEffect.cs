using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectEffect : NetworkType
{

	public const uint Id = 76;
	public override uint MessageId { get { return Id; } }

	public short ActionId { get; set; }

	public ObjectEffect() {}


	public ObjectEffect InitObjectEffect(short ActionId)
	{
		this.ActionId = ActionId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.ActionId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ActionId = reader.ReadVarShort();
	}
}
}
