using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class SymbioticObjectAssociatedMessage : NetworkMessage
{

	public const uint Id = 6527;
	public override uint MessageId { get { return Id; } }

	public int HostUID { get; set; }

	public SymbioticObjectAssociatedMessage() {}


	public SymbioticObjectAssociatedMessage InitSymbioticObjectAssociatedMessage(int HostUID)
	{
		this.HostUID = HostUID;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.HostUID);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.HostUID = reader.ReadVarInt();
	}
}
}
