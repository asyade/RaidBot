using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayArenaSwitchToGameServerMessage : NetworkMessage
{

	public const uint Id = 6574;
	public override uint MessageId { get { return Id; } }

	public bool ValidToken { get; set; }
	public byte[] Ticket { get; set; }
	public short HomeServerId { get; set; }

	public GameRolePlayArenaSwitchToGameServerMessage() {}


	public GameRolePlayArenaSwitchToGameServerMessage InitGameRolePlayArenaSwitchToGameServerMessage(bool ValidToken, byte[] Ticket, short HomeServerId)
	{
		this.ValidToken = ValidToken;
		this.Ticket = Ticket;
		this.HomeServerId = HomeServerId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.ValidToken);
		writer.WriteVarInt(this.Ticket.Length);
		foreach (byte item in this.Ticket)
		{
			writer.WriteByte(item);
		}
		writer.WriteShort(this.HomeServerId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ValidToken = reader.ReadBoolean();
		int TicketLen = reader.ReadVarInt();
		Ticket = new byte[TicketLen];
		for (int i = 0; i < TicketLen; i++)
		{
			this.Ticket[i] = reader.ReadByte();
		}
		this.HomeServerId = reader.ReadShort();
	}
}
}
