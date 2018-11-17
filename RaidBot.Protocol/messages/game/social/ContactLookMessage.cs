using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ContactLookMessage : NetworkMessage
{

	public const uint Id = 5934;
	public override uint MessageId { get { return Id; } }

	public int RequestId { get; set; }
	public String PlayerName { get; set; }
	public long PlayerId { get; set; }
	public EntityLook Look { get; set; }

	public ContactLookMessage() {}


	public ContactLookMessage InitContactLookMessage(int RequestId, String PlayerName, long PlayerId, EntityLook Look)
	{
		this.RequestId = RequestId;
		this.PlayerName = PlayerName;
		this.PlayerId = PlayerId;
		this.Look = Look;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.RequestId);
		writer.WriteUTF(this.PlayerName);
		writer.WriteVarLong(this.PlayerId);
		this.Look.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.RequestId = reader.ReadVarInt();
		this.PlayerName = reader.ReadUTF();
		this.PlayerId = reader.ReadVarLong();
		this.Look = new EntityLook();
		this.Look.Deserialize(reader);
	}
}
}
