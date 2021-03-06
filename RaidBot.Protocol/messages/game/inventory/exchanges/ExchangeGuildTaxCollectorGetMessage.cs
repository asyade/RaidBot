using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeGuildTaxCollectorGetMessage : NetworkMessage
{

	public const uint Id = 5762;
	public override uint MessageId { get { return Id; } }

	public String CollectorName { get; set; }
	public short WorldX { get; set; }
	public short WorldY { get; set; }
	public double MapId { get; set; }
	public short SubAreaId { get; set; }
	public String UserName { get; set; }
	public long CallerId { get; set; }
	public String CallerName { get; set; }
	public double Experience { get; set; }
	public short Pods { get; set; }
	public ObjectItemGenericQuantity[] ObjectsInfos { get; set; }

	public ExchangeGuildTaxCollectorGetMessage() {}


	public ExchangeGuildTaxCollectorGetMessage InitExchangeGuildTaxCollectorGetMessage(String CollectorName, short WorldX, short WorldY, double MapId, short SubAreaId, String UserName, long CallerId, String CallerName, double Experience, short Pods, ObjectItemGenericQuantity[] ObjectsInfos)
	{
		this.CollectorName = CollectorName;
		this.WorldX = WorldX;
		this.WorldY = WorldY;
		this.MapId = MapId;
		this.SubAreaId = SubAreaId;
		this.UserName = UserName;
		this.CallerId = CallerId;
		this.CallerName = CallerName;
		this.Experience = Experience;
		this.Pods = Pods;
		this.ObjectsInfos = ObjectsInfos;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.CollectorName);
		writer.WriteShort(this.WorldX);
		writer.WriteShort(this.WorldY);
		writer.WriteDouble(this.MapId);
		writer.WriteVarShort(this.SubAreaId);
		writer.WriteUTF(this.UserName);
		writer.WriteVarLong(this.CallerId);
		writer.WriteUTF(this.CallerName);
		writer.WriteDouble(this.Experience);
		writer.WriteVarShort(this.Pods);
		writer.WriteShort(this.ObjectsInfos.Length);
		foreach (ObjectItemGenericQuantity item in this.ObjectsInfos)
		{
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.CollectorName = reader.ReadUTF();
		this.WorldX = reader.ReadShort();
		this.WorldY = reader.ReadShort();
		this.MapId = reader.ReadDouble();
		this.SubAreaId = reader.ReadVarShort();
		this.UserName = reader.ReadUTF();
		this.CallerId = reader.ReadVarLong();
		this.CallerName = reader.ReadUTF();
		this.Experience = reader.ReadDouble();
		this.Pods = reader.ReadVarShort();
		int ObjectsInfosLen = reader.ReadShort();
		ObjectsInfos = new ObjectItemGenericQuantity[ObjectsInfosLen];
		for (int i = 0; i < ObjectsInfosLen; i++)
		{
			this.ObjectsInfos[i] = new ObjectItemGenericQuantity();
			this.ObjectsInfos[i].Deserialize(reader);
		}
	}
}
}
