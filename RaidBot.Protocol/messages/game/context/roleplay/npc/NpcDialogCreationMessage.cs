using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class NpcDialogCreationMessage : NetworkMessage
{

	public const uint Id = 5618;
	public override uint MessageId { get { return Id; } }

	public double MapId { get; set; }
	public int NpcId { get; set; }

	public NpcDialogCreationMessage() {}


	public NpcDialogCreationMessage InitNpcDialogCreationMessage(double MapId, int NpcId)
	{
		this.MapId = MapId;
		this.NpcId = NpcId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.MapId);
		writer.WriteInt(this.NpcId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MapId = reader.ReadDouble();
		this.NpcId = reader.ReadInt();
	}
}
}
