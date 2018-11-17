using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AccountCapabilitiesMessage : NetworkMessage
{

	public const uint Id = 6216;
	public override uint MessageId { get { return Id; } }

	public bool TutorialAvailable { get; set; }
	public bool CanCreateNewCharacter { get; set; }
	public int AccountId { get; set; }
	public int BreedsVisible { get; set; }
	public int BreedsAvailable { get; set; }
	public byte Status { get; set; }
	public double UnlimitedRestatEndDate { get; set; }

	public AccountCapabilitiesMessage() {}


	public AccountCapabilitiesMessage InitAccountCapabilitiesMessage(bool TutorialAvailable, bool CanCreateNewCharacter, int AccountId, int BreedsVisible, int BreedsAvailable, byte Status, double UnlimitedRestatEndDate)
	{
		this.TutorialAvailable = TutorialAvailable;
		this.CanCreateNewCharacter = CanCreateNewCharacter;
		this.AccountId = AccountId;
		this.BreedsVisible = BreedsVisible;
		this.BreedsAvailable = BreedsAvailable;
		this.Status = Status;
		this.UnlimitedRestatEndDate = UnlimitedRestatEndDate;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		byte box = 0;
		box = BooleanByteWrapper.SetFlag(box, 0, TutorialAvailable);
		box = BooleanByteWrapper.SetFlag(box, 1, CanCreateNewCharacter);
		writer.WriteByte(box);
		writer.WriteInt(this.AccountId);
		writer.WriteVarInt(this.BreedsVisible);
		writer.WriteVarInt(this.BreedsAvailable);
		writer.WriteByte(this.Status);
		writer.WriteDouble(this.UnlimitedRestatEndDate);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		byte box = reader.ReadByte();
		this.TutorialAvailable = BooleanByteWrapper.GetFlag(box, 0);
		this.CanCreateNewCharacter = BooleanByteWrapper.GetFlag(box, 1);
		this.AccountId = reader.ReadInt();
		this.BreedsVisible = reader.ReadVarInt();
		this.BreedsAvailable = reader.ReadVarInt();
		this.Status = reader.ReadByte();
		this.UnlimitedRestatEndDate = reader.ReadDouble();
	}
}
}
