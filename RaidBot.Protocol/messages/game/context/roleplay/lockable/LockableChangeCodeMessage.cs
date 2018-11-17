using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class LockableChangeCodeMessage : NetworkMessage
{

	public const uint Id = 5666;
	public override uint MessageId { get { return Id; } }

	public String Code { get; set; }

	public LockableChangeCodeMessage() {}


	public LockableChangeCodeMessage InitLockableChangeCodeMessage(String Code)
	{
		this.Code = Code;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.Code);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Code = reader.ReadUTF();
	}
}
}
