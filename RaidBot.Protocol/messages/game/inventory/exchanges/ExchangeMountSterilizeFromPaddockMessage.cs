using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeMountSterilizeFromPaddockMessage : NetworkMessage
{

	public const uint Id = 6056;
	public override uint MessageId { get { return Id; } }

	public String Name { get; set; }
	public short WorldX { get; set; }
	public short WorldY { get; set; }
	public String Sterilizator { get; set; }

	public ExchangeMountSterilizeFromPaddockMessage() {}


	public ExchangeMountSterilizeFromPaddockMessage InitExchangeMountSterilizeFromPaddockMessage(String Name, short WorldX, short WorldY, String Sterilizator)
	{
		this.Name = Name;
		this.WorldX = WorldX;
		this.WorldY = WorldY;
		this.Sterilizator = Sterilizator;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.Name);
		writer.WriteShort(this.WorldX);
		writer.WriteShort(this.WorldY);
		writer.WriteUTF(this.Sterilizator);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Name = reader.ReadUTF();
		this.WorldX = reader.ReadShort();
		this.WorldY = reader.ReadShort();
		this.Sterilizator = reader.ReadUTF();
	}
}
}
