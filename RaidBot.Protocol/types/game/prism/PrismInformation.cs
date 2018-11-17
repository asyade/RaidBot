using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PrismInformation : NetworkType
{

	public const uint Id = 428;
	public override uint MessageId { get { return Id; } }

	public byte TypeId { get; set; }
	public byte State { get; set; }
	public int NextVulnerabilityDate { get; set; }
	public int PlacementDate { get; set; }
	public int RewardTokenCount { get; set; }

	public PrismInformation() {}


	public PrismInformation InitPrismInformation(byte TypeId, byte State, int NextVulnerabilityDate, int PlacementDate, int RewardTokenCount)
	{
		this.TypeId = TypeId;
		this.State = State;
		this.NextVulnerabilityDate = NextVulnerabilityDate;
		this.PlacementDate = PlacementDate;
		this.RewardTokenCount = RewardTokenCount;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.TypeId);
		writer.WriteByte(this.State);
		writer.WriteInt(this.NextVulnerabilityDate);
		writer.WriteInt(this.PlacementDate);
		writer.WriteVarInt(this.RewardTokenCount);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.TypeId = reader.ReadByte();
		this.State = reader.ReadByte();
		this.NextVulnerabilityDate = reader.ReadInt();
		this.PlacementDate = reader.ReadInt();
		this.RewardTokenCount = reader.ReadVarInt();
	}
}
}
