using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AllianceInsiderPrismInformation : PrismInformation
{

	public const uint Id = 431;
	public override uint MessageId { get { return Id; } }

	public int LastTimeSlotModificationDate { get; set; }
	public int LastTimeSlotModificationAuthorGuildId { get; set; }
	public long LastTimeSlotModificationAuthorId { get; set; }
	public String LastTimeSlotModificationAuthorName { get; set; }
	public ObjectItem[] ModulesObjects { get; set; }

	public AllianceInsiderPrismInformation() {}


	public AllianceInsiderPrismInformation InitAllianceInsiderPrismInformation(int LastTimeSlotModificationDate, int LastTimeSlotModificationAuthorGuildId, long LastTimeSlotModificationAuthorId, String LastTimeSlotModificationAuthorName, ObjectItem[] ModulesObjects)
	{
		this.LastTimeSlotModificationDate = LastTimeSlotModificationDate;
		this.LastTimeSlotModificationAuthorGuildId = LastTimeSlotModificationAuthorGuildId;
		this.LastTimeSlotModificationAuthorId = LastTimeSlotModificationAuthorId;
		this.LastTimeSlotModificationAuthorName = LastTimeSlotModificationAuthorName;
		this.ModulesObjects = ModulesObjects;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteInt(this.LastTimeSlotModificationDate);
		writer.WriteVarInt(this.LastTimeSlotModificationAuthorGuildId);
		writer.WriteVarLong(this.LastTimeSlotModificationAuthorId);
		writer.WriteUTF(this.LastTimeSlotModificationAuthorName);
		writer.WriteShort(this.ModulesObjects.Length);
		foreach (ObjectItem item in this.ModulesObjects)
		{
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.LastTimeSlotModificationDate = reader.ReadInt();
		this.LastTimeSlotModificationAuthorGuildId = reader.ReadVarInt();
		this.LastTimeSlotModificationAuthorId = reader.ReadVarLong();
		this.LastTimeSlotModificationAuthorName = reader.ReadUTF();
		int ModulesObjectsLen = reader.ReadShort();
		ModulesObjects = new ObjectItem[ModulesObjectsLen];
		for (int i = 0; i < ModulesObjectsLen; i++)
		{
			this.ModulesObjects[i] = new ObjectItem();
			this.ModulesObjects[i].Deserialize(reader);
		}
	}
}
}
