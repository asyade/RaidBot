using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class InteractiveUseRequestMessage : NetworkMessage
{

	public const uint Id = 5001;
	public override uint MessageId { get { return Id; } }

	public int ElemId { get; set; }
	public int SkillInstanceUid { get; set; }

	public InteractiveUseRequestMessage() {}


	public InteractiveUseRequestMessage InitInteractiveUseRequestMessage(int ElemId, int SkillInstanceUid)
	{
		this.ElemId = ElemId;
		this.SkillInstanceUid = SkillInstanceUid;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.ElemId);
		writer.WriteVarInt(this.SkillInstanceUid);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ElemId = reader.ReadVarInt();
		this.SkillInstanceUid = reader.ReadVarInt();
	}
}
}
