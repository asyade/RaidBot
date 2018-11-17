using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class IndexedEntityLook : NetworkType
{

	public const uint Id = 405;
	public override uint MessageId { get { return Id; } }

	public EntityLook Look { get; set; }
	public byte Index { get; set; }

	public IndexedEntityLook() {}


	public IndexedEntityLook InitIndexedEntityLook(EntityLook Look, byte Index)
	{
		this.Look = Look;
		this.Index = Index;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.Look.Serialize(writer);
		writer.WriteByte(this.Index);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Look = new EntityLook();
		this.Look.Deserialize(reader);
		this.Index = reader.ReadByte();
	}
}
}
