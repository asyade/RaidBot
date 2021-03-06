using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildInformationsPaddocksMessage : NetworkMessage
{

	public const uint Id = 5959;
	public override uint MessageId { get { return Id; } }

	public byte NbPaddockMax { get; set; }
	public PaddockContentInformations[] PaddocksInformations { get; set; }

	public GuildInformationsPaddocksMessage() {}


	public GuildInformationsPaddocksMessage InitGuildInformationsPaddocksMessage(byte NbPaddockMax, PaddockContentInformations[] PaddocksInformations)
	{
		this.NbPaddockMax = NbPaddockMax;
		this.PaddocksInformations = PaddocksInformations;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.NbPaddockMax);
		writer.WriteShort(this.PaddocksInformations.Length);
		foreach (PaddockContentInformations item in this.PaddocksInformations)
		{
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.NbPaddockMax = reader.ReadByte();
		int PaddocksInformationsLen = reader.ReadShort();
		PaddocksInformations = new PaddockContentInformations[PaddocksInformationsLen];
		for (int i = 0; i < PaddocksInformationsLen; i++)
		{
			this.PaddocksInformations[i] = new PaddockContentInformations();
			this.PaddocksInformations[i].Deserialize(reader);
		}
	}
}
}
