using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class DareWonListMessage : NetworkMessage
{

	public const uint Id = 6682;
	public override uint MessageId { get { return Id; } }

	public double[] DareId { get; set; }

	public DareWonListMessage() {}


	public DareWonListMessage InitDareWonListMessage(double[] DareId)
	{
		this.DareId = DareId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.DareId.Length);
		foreach (double item in this.DareId)
		{
			writer.WriteDouble(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		int DareIdLen = reader.ReadShort();
		DareId = new double[DareIdLen];
		for (int i = 0; i < DareIdLen; i++)
		{
			this.DareId[i] = reader.ReadDouble();
		}
	}
}
}
