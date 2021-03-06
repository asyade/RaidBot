using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TaxCollectorInformations : NetworkType
{

	public const uint Id = 167;
	public override uint MessageId { get { return Id; } }

	public double UniqueId { get; set; }
	public short FirtNameId { get; set; }
	public short LastNameId { get; set; }
	public AdditionalTaxCollectorInformations AdditionalInfos { get; set; }
	public short WorldX { get; set; }
	public short WorldY { get; set; }
	public short SubAreaId { get; set; }
	public byte State { get; set; }
	public EntityLook Look { get; set; }
	public TaxCollectorComplementaryInformations[] Complements { get; set; }

	public TaxCollectorInformations() {}


	public TaxCollectorInformations InitTaxCollectorInformations(double UniqueId, short FirtNameId, short LastNameId, AdditionalTaxCollectorInformations AdditionalInfos, short WorldX, short WorldY, short SubAreaId, byte State, EntityLook Look, TaxCollectorComplementaryInformations[] Complements)
	{
		this.UniqueId = UniqueId;
		this.FirtNameId = FirtNameId;
		this.LastNameId = LastNameId;
		this.AdditionalInfos = AdditionalInfos;
		this.WorldX = WorldX;
		this.WorldY = WorldY;
		this.SubAreaId = SubAreaId;
		this.State = State;
		this.Look = Look;
		this.Complements = Complements;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.UniqueId);
		writer.WriteVarShort(this.FirtNameId);
		writer.WriteVarShort(this.LastNameId);
		this.AdditionalInfos.Serialize(writer);
		writer.WriteShort(this.WorldX);
		writer.WriteShort(this.WorldY);
		writer.WriteVarShort(this.SubAreaId);
		writer.WriteByte(this.State);
		this.Look.Serialize(writer);
		writer.WriteShort(this.Complements.Length);
		foreach (TaxCollectorComplementaryInformations item in this.Complements)
		{
			writer.WriteShort(item.MessageId);
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.UniqueId = reader.ReadDouble();
		this.FirtNameId = reader.ReadVarShort();
		this.LastNameId = reader.ReadVarShort();
		this.AdditionalInfos = new AdditionalTaxCollectorInformations();
		this.AdditionalInfos.Deserialize(reader);
		this.WorldX = reader.ReadShort();
		this.WorldY = reader.ReadShort();
		this.SubAreaId = reader.ReadVarShort();
		this.State = reader.ReadByte();
		this.Look = new EntityLook();
		this.Look.Deserialize(reader);
		int ComplementsLen = reader.ReadShort();
		Complements = new TaxCollectorComplementaryInformations[ComplementsLen];
		for (int i = 0; i < ComplementsLen; i++)
		{
			this.Complements[i] = ProtocolTypeManager.GetInstance<TaxCollectorComplementaryInformations>(reader.ReadShort());
			this.Complements[i].Deserialize(reader);
		}
	}
}
}
