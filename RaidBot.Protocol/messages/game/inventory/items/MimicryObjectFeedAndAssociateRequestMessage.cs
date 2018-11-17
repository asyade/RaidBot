using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MimicryObjectFeedAndAssociateRequestMessage : SymbioticObjectAssociateRequestMessage
{

	public const uint Id = 6460;
	public override uint MessageId { get { return Id; } }

	public int FoodUID { get; set; }
	public byte FoodPos { get; set; }
	public bool Preview { get; set; }

	public MimicryObjectFeedAndAssociateRequestMessage() {}


	public MimicryObjectFeedAndAssociateRequestMessage InitMimicryObjectFeedAndAssociateRequestMessage(int FoodUID, byte FoodPos, bool Preview)
	{
		this.FoodUID = FoodUID;
		this.FoodPos = FoodPos;
		this.Preview = Preview;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarInt(this.FoodUID);
		writer.WriteByte(this.FoodPos);
		writer.WriteBoolean(this.Preview);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.FoodUID = reader.ReadVarInt();
		this.FoodPos = reader.ReadByte();
		this.Preview = reader.ReadBoolean();
	}
}
}
