using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AbstractFightTeamInformations : NetworkType
{

	public const uint Id = 116;
	public override uint MessageId { get { return Id; } }

	public byte TeamId { get; set; }
	public double LeaderId { get; set; }
	public byte TeamSide { get; set; }
	public byte TeamTypeId { get; set; }
	public byte NbWaves { get; set; }

	public AbstractFightTeamInformations() {}


	public AbstractFightTeamInformations InitAbstractFightTeamInformations(byte TeamId, double LeaderId, byte TeamSide, byte TeamTypeId, byte NbWaves)
	{
		this.TeamId = TeamId;
		this.LeaderId = LeaderId;
		this.TeamSide = TeamSide;
		this.TeamTypeId = TeamTypeId;
		this.NbWaves = NbWaves;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.TeamId);
		writer.WriteDouble(this.LeaderId);
		writer.WriteByte(this.TeamSide);
		writer.WriteByte(this.TeamTypeId);
		writer.WriteByte(this.NbWaves);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.TeamId = reader.ReadByte();
		this.LeaderId = reader.ReadDouble();
		this.TeamSide = reader.ReadByte();
		this.TeamTypeId = reader.ReadByte();
		this.NbWaves = reader.ReadByte();
	}
}
}
