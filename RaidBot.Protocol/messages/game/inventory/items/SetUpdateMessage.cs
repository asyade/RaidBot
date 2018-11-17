using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class SetUpdateMessage : NetworkMessage
{

	public const uint Id = 5503;
	public override uint MessageId { get { return Id; } }

	public short SetId { get; set; }
	public short[] SetObjects { get; set; }
	public ObjectEffect[] SetEffects { get; set; }

	public SetUpdateMessage() {}


	public SetUpdateMessage InitSetUpdateMessage(short SetId, short[] SetObjects, ObjectEffect[] SetEffects)
	{
		this.SetId = SetId;
		this.SetObjects = SetObjects;
		this.SetEffects = SetEffects;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.SetId);
		writer.WriteShort(this.SetObjects.Length);
		foreach (short item in this.SetObjects)
		{
			writer.WriteVarShort(item);
		}
		writer.WriteShort(this.SetEffects.Length);
		foreach (ObjectEffect item in this.SetEffects)
		{
			writer.WriteShort(item.MessageId);
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SetId = reader.ReadVarShort();
		int SetObjectsLen = reader.ReadShort();
		SetObjects = new short[SetObjectsLen];
		for (int i = 0; i < SetObjectsLen; i++)
		{
			this.SetObjects[i] = reader.ReadVarShort();
		}
		int SetEffectsLen = reader.ReadShort();
		SetEffects = new ObjectEffect[SetEffectsLen];
		for (int i = 0; i < SetEffectsLen; i++)
		{
			this.SetEffects[i] = ProtocolTypeManager.GetInstance<ObjectEffect>(reader.ReadShort());
			this.SetEffects[i].Deserialize(reader);
		}
	}
}
}
