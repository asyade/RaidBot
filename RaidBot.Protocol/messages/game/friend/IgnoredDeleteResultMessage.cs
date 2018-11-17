using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class IgnoredDeleteResultMessage : NetworkMessage
{

	public const uint Id = 5677;
	public override uint MessageId { get { return Id; } }

	public bool Success { get; set; }
	public bool Session { get; set; }
	public String Name { get; set; }

	public IgnoredDeleteResultMessage() {}


	public IgnoredDeleteResultMessage InitIgnoredDeleteResultMessage(bool Success, bool Session, String Name)
	{
		this.Success = Success;
		this.Session = Session;
		this.Name = Name;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		byte box = 0;
		box = BooleanByteWrapper.SetFlag(box, 0, Success);
		box = BooleanByteWrapper.SetFlag(box, 1, Session);
		writer.WriteByte(box);
		writer.WriteUTF(this.Name);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		byte box = reader.ReadByte();
		this.Success = BooleanByteWrapper.GetFlag(box, 0);
		this.Session = BooleanByteWrapper.GetFlag(box, 1);
		this.Name = reader.ReadUTF();
	}
}
}
