using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class SymbioticObjectAssociateRequestMessage : NetworkMessage
{

	public const uint Id = 6522;
	public override uint MessageId { get { return Id; } }

	public int SymbioteUID { get; set; }
	public byte SymbiotePos { get; set; }
	public int HostUID { get; set; }
	public byte HostPos { get; set; }

	public SymbioticObjectAssociateRequestMessage() {}


	public SymbioticObjectAssociateRequestMessage InitSymbioticObjectAssociateRequestMessage(int SymbioteUID, byte SymbiotePos, int HostUID, byte HostPos)
	{
		this.SymbioteUID = SymbioteUID;
		this.SymbiotePos = SymbiotePos;
		this.HostUID = HostUID;
		this.HostPos = HostPos;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.SymbioteUID);
		writer.WriteByte(this.SymbiotePos);
		writer.WriteVarInt(this.HostUID);
		writer.WriteByte(this.HostPos);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SymbioteUID = reader.ReadVarInt();
		this.SymbiotePos = reader.ReadByte();
		this.HostUID = reader.ReadVarInt();
		this.HostPos = reader.ReadByte();
	}
}
}
