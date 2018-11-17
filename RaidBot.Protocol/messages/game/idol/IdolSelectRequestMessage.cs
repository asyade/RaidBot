using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class IdolSelectRequestMessage : NetworkMessage
{

	public const uint Id = 6587;
	public override uint MessageId { get { return Id; } }

	public bool Activate { get; set; }
	public bool Party { get; set; }
	public short IdolId { get; set; }

	public IdolSelectRequestMessage() {}


	public IdolSelectRequestMessage InitIdolSelectRequestMessage(bool Activate, bool Party, short IdolId)
	{
		this.Activate = Activate;
		this.Party = Party;
		this.IdolId = IdolId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		byte box = 0;
		box = BooleanByteWrapper.SetFlag(box, 0, Activate);
		box = BooleanByteWrapper.SetFlag(box, 1, Party);
		writer.WriteByte(box);
		writer.WriteVarShort(this.IdolId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		byte box = reader.ReadByte();
		this.Activate = BooleanByteWrapper.GetFlag(box, 0);
		this.Party = BooleanByteWrapper.GetFlag(box, 1);
		this.IdolId = reader.ReadVarShort();
	}
}
}
