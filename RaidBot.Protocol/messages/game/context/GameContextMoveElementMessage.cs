using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameContextMoveElementMessage : NetworkMessage
{

	public const uint Id = 253;
	public override uint MessageId { get { return Id; } }

	public EntityMovementInformations Movement { get; set; }

	public GameContextMoveElementMessage() {}


	public GameContextMoveElementMessage InitGameContextMoveElementMessage(EntityMovementInformations Movement)
	{
		this.Movement = Movement;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.Movement.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Movement = new EntityMovementInformations();
		this.Movement.Deserialize(reader);
	}
}
}
