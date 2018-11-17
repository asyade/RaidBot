using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightTaxCollectorInformations : GameFightAIInformations
{

	public const uint Id = 48;
	public override uint MessageId { get { return Id; } }

	public short FirstNameId { get; set; }
	public short LastNameId { get; set; }
	public byte Level { get; set; }

	public GameFightTaxCollectorInformations() {}


	public GameFightTaxCollectorInformations InitGameFightTaxCollectorInformations(short FirstNameId, short LastNameId, byte Level)
	{
		this.FirstNameId = FirstNameId;
		this.LastNameId = LastNameId;
		this.Level = Level;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.FirstNameId);
		writer.WriteVarShort(this.LastNameId);
		writer.WriteByte(this.Level);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.FirstNameId = reader.ReadVarShort();
		this.LastNameId = reader.ReadVarShort();
		this.Level = reader.ReadByte();
	}
}
}
