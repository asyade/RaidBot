using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class LockableStateUpdateAbstractMessage : NetworkMessage
{

	public const uint Id = 5671;
	public override uint MessageId { get { return Id; } }

	public bool Locked { get; set; }

	public LockableStateUpdateAbstractMessage() {}


	public LockableStateUpdateAbstractMessage InitLockableStateUpdateAbstractMessage(bool Locked)
	{
		this.Locked = Locked;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.Locked);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Locked = reader.ReadBoolean();
	}
}
}
