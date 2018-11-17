using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectEffectDice : ObjectEffect
{

	public const uint Id = 73;
	public override uint MessageId { get { return Id; } }

	public int DiceNum { get; set; }
	public int DiceSide { get; set; }
	public int DiceConst { get; set; }

	public ObjectEffectDice() {}


	public ObjectEffectDice InitObjectEffectDice(int DiceNum, int DiceSide, int DiceConst)
	{
		this.DiceNum = DiceNum;
		this.DiceSide = DiceSide;
		this.DiceConst = DiceConst;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarInt(this.DiceNum);
		writer.WriteVarInt(this.DiceSide);
		writer.WriteVarInt(this.DiceConst);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.DiceNum = reader.ReadVarInt();
		this.DiceSide = reader.ReadVarInt();
		this.DiceConst = reader.ReadVarInt();
	}
}
}
