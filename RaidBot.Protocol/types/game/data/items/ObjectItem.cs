using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectItem : Item
{

	public const uint Id = 37;
	public override uint MessageId { get { return Id; } }

	public short Position { get; set; }
	public short ObjectGID { get; set; }
	public ObjectEffect[] Effects { get; set; }
	public int ObjectUID { get; set; }
	public int Quantity { get; set; }

	public ObjectItem() {}


	public ObjectItem InitObjectItem(short Position, short ObjectGID, ObjectEffect[] Effects, int ObjectUID, int Quantity)
	{
		this.Position = Position;
		this.ObjectGID = ObjectGID;
		this.Effects = Effects;
		this.ObjectUID = ObjectUID;
		this.Quantity = Quantity;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteShort(this.Position);
		writer.WriteVarShort(this.ObjectGID);
		writer.WriteShort(this.Effects.Length);
		foreach (ObjectEffect item in this.Effects)
		{
			writer.WriteShort(item.MessageId);
			item.Serialize(writer);
		}
		writer.WriteVarInt(this.ObjectUID);
		writer.WriteVarInt(this.Quantity);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Position = reader.ReadShort();
		this.ObjectGID = reader.ReadVarShort();
		int EffectsLen = reader.ReadShort();
		Effects = new ObjectEffect[EffectsLen];
		for (int i = 0; i < EffectsLen; i++)
		{
			this.Effects[i] = ProtocolTypeManager.GetInstance<ObjectEffect>(reader.ReadShort());
			this.Effects[i].Deserialize(reader);
		}
		this.ObjectUID = reader.ReadVarInt();
		this.Quantity = reader.ReadVarInt();
	}
}
}
