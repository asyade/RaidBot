using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CompassUpdatePartyMemberMessage : CompassUpdateMessage
{

	public const uint Id = 5589;
	public override uint MessageId { get { return Id; } }

	public long MemberId { get; set; }
	public bool Active { get; set; }

	public CompassUpdatePartyMemberMessage() {}


	public CompassUpdatePartyMemberMessage InitCompassUpdatePartyMemberMessage(long MemberId, bool Active)
	{
		this.MemberId = MemberId;
		this.Active = Active;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarLong(this.MemberId);
		writer.WriteBoolean(this.Active);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.MemberId = reader.ReadVarLong();
		this.Active = reader.ReadBoolean();
	}
}
}
