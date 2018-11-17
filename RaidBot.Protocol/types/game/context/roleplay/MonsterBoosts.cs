using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MonsterBoosts : NetworkType
{

	public const uint Id = 497;
	public override uint MessageId { get { return Id; } }

	public int Id_ { get; set; }
	public short XpBoost { get; set; }
	public short DropBoost { get; set; }

	public MonsterBoosts() {}


	public MonsterBoosts InitMonsterBoosts(int Id_, short XpBoost, short DropBoost)
	{
		this.Id_ = Id_;
		this.XpBoost = XpBoost;
		this.DropBoost = DropBoost;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.Id_);
		writer.WriteVarShort(this.XpBoost);
		writer.WriteVarShort(this.DropBoost);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Id_ = reader.ReadVarInt();
		this.XpBoost = reader.ReadVarShort();
		this.DropBoost = reader.ReadVarShort();
	}
}
}
