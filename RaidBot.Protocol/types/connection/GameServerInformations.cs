using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameServerInformations : NetworkType
{

	public const uint Id = 25;
	public override uint MessageId { get { return Id; } }

	public bool IsMonoAccount { get; set; }
	public bool IsSelectable { get; set; }
	public short Id_ { get; set; }
	public byte Type { get; set; }
	public byte Status { get; set; }
	public byte Completion { get; set; }
	public byte CharactersCount { get; set; }
	public byte CharactersSlots { get; set; }
	public double Date { get; set; }

	public GameServerInformations() {}


	public GameServerInformations InitGameServerInformations(bool IsMonoAccount, bool IsSelectable, short Id_, byte Type, byte Status, byte Completion, byte CharactersCount, byte CharactersSlots, double Date)
	{
		this.IsMonoAccount = IsMonoAccount;
		this.IsSelectable = IsSelectable;
		this.Id_ = Id_;
		this.Type = Type;
		this.Status = Status;
		this.Completion = Completion;
		this.CharactersCount = CharactersCount;
		this.CharactersSlots = CharactersSlots;
		this.Date = Date;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		byte box = 0;
		box = BooleanByteWrapper.SetFlag(box, 0, IsMonoAccount);
		box = BooleanByteWrapper.SetFlag(box, 1, IsSelectable);
		writer.WriteByte(box);
		writer.WriteVarShort(this.Id_);
		writer.WriteByte(this.Type);
		writer.WriteByte(this.Status);
		writer.WriteByte(this.Completion);
		writer.WriteByte(this.CharactersCount);
		writer.WriteByte(this.CharactersSlots);
		writer.WriteDouble(this.Date);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		byte box = reader.ReadByte();
		this.IsMonoAccount = BooleanByteWrapper.GetFlag(box, 0);
		this.IsSelectable = BooleanByteWrapper.GetFlag(box, 1);
		this.Id_ = reader.ReadVarShort();
		this.Type = reader.ReadByte();
		this.Status = reader.ReadByte();
		this.Completion = reader.ReadByte();
		this.CharactersCount = reader.ReadByte();
		this.CharactersSlots = reader.ReadByte();
		this.Date = reader.ReadDouble();
	}
}
}
