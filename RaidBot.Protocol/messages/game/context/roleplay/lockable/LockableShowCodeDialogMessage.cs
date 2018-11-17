using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class LockableShowCodeDialogMessage : NetworkMessage
{

	public const uint Id = 5740;
	public override uint MessageId { get { return Id; } }

	public bool ChangeOrUse { get; set; }
	public byte CodeSize { get; set; }

	public LockableShowCodeDialogMessage() {}


	public LockableShowCodeDialogMessage InitLockableShowCodeDialogMessage(bool ChangeOrUse, byte CodeSize)
	{
		this.ChangeOrUse = ChangeOrUse;
		this.CodeSize = CodeSize;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.ChangeOrUse);
		writer.WriteByte(this.CodeSize);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ChangeOrUse = reader.ReadBoolean();
		this.CodeSize = reader.ReadByte();
	}
}
}
