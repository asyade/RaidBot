using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ComicReadingBeginMessage : NetworkMessage
{

	public const uint Id = 6536;
	public override uint MessageId { get { return Id; } }

	public short ComicId { get; set; }

	public ComicReadingBeginMessage() {}


	public ComicReadingBeginMessage InitComicReadingBeginMessage(short ComicId)
	{
		this.ComicId = ComicId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.ComicId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ComicId = reader.ReadVarShort();
	}
}
}
