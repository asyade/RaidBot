using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class JobExperience : NetworkType
{

	public const uint Id = 98;
	public override uint MessageId { get { return Id; } }

	public byte JobId { get; set; }
	public byte JobLevel { get; set; }
	public long JobXP { get; set; }
	public long JobXpLevelFloor { get; set; }
	public long JobXpNextLevelFloor { get; set; }

	public JobExperience() {}


	public JobExperience InitJobExperience(byte JobId, byte JobLevel, long JobXP, long JobXpLevelFloor, long JobXpNextLevelFloor)
	{
		this.JobId = JobId;
		this.JobLevel = JobLevel;
		this.JobXP = JobXP;
		this.JobXpLevelFloor = JobXpLevelFloor;
		this.JobXpNextLevelFloor = JobXpNextLevelFloor;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.JobId);
		writer.WriteByte(this.JobLevel);
		writer.WriteVarLong(this.JobXP);
		writer.WriteVarLong(this.JobXpLevelFloor);
		writer.WriteVarLong(this.JobXpNextLevelFloor);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.JobId = reader.ReadByte();
		this.JobLevel = reader.ReadByte();
		this.JobXP = reader.ReadVarLong();
		this.JobXpLevelFloor = reader.ReadVarLong();
		this.JobXpNextLevelFloor = reader.ReadVarLong();
	}
}
}
