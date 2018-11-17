using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildInformationsGeneralMessage : NetworkMessage
{

	public const uint Id = 5557;
	public override uint MessageId { get { return Id; } }

	public bool AbandonnedPaddock { get; set; }
	public byte Level { get; set; }
	public long ExpLevelFloor { get; set; }
	public long Experience { get; set; }
	public long ExpNextLevelFloor { get; set; }
	public int CreationDate { get; set; }
	public short NbTotalMembers { get; set; }
	public short NbConnectedMembers { get; set; }

	public GuildInformationsGeneralMessage() {}


	public GuildInformationsGeneralMessage InitGuildInformationsGeneralMessage(bool AbandonnedPaddock, byte Level, long ExpLevelFloor, long Experience, long ExpNextLevelFloor, int CreationDate, short NbTotalMembers, short NbConnectedMembers)
	{
		this.AbandonnedPaddock = AbandonnedPaddock;
		this.Level = Level;
		this.ExpLevelFloor = ExpLevelFloor;
		this.Experience = Experience;
		this.ExpNextLevelFloor = ExpNextLevelFloor;
		this.CreationDate = CreationDate;
		this.NbTotalMembers = NbTotalMembers;
		this.NbConnectedMembers = NbConnectedMembers;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.AbandonnedPaddock);
		writer.WriteByte(this.Level);
		writer.WriteVarLong(this.ExpLevelFloor);
		writer.WriteVarLong(this.Experience);
		writer.WriteVarLong(this.ExpNextLevelFloor);
		writer.WriteInt(this.CreationDate);
		writer.WriteVarShort(this.NbTotalMembers);
		writer.WriteVarShort(this.NbConnectedMembers);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.AbandonnedPaddock = reader.ReadBoolean();
		this.Level = reader.ReadByte();
		this.ExpLevelFloor = reader.ReadVarLong();
		this.Experience = reader.ReadVarLong();
		this.ExpNextLevelFloor = reader.ReadVarLong();
		this.CreationDate = reader.ReadInt();
		this.NbTotalMembers = reader.ReadVarShort();
		this.NbConnectedMembers = reader.ReadVarShort();
	}
}
}
