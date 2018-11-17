using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AlignmentRankUpdateMessage : NetworkMessage
{

	public const uint Id = 6058;
	public override uint MessageId { get { return Id; } }

	public byte AlignmentRank { get; set; }
	public bool Verbose { get; set; }

	public AlignmentRankUpdateMessage() {}


	public AlignmentRankUpdateMessage InitAlignmentRankUpdateMessage(byte AlignmentRank, bool Verbose)
	{
		this.AlignmentRank = AlignmentRank;
		this.Verbose = Verbose;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.AlignmentRank);
		writer.WriteBoolean(this.Verbose);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.AlignmentRank = reader.ReadByte();
		this.Verbose = reader.ReadBoolean();
	}
}
}
