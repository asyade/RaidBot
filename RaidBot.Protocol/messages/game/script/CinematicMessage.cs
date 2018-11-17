using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CinematicMessage : NetworkMessage
{

	public const uint Id = 6053;
	public override uint MessageId { get { return Id; } }

	public short CinematicId { get; set; }

	public CinematicMessage() {}


	public CinematicMessage InitCinematicMessage(short CinematicId)
	{
		this.CinematicId = CinematicId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.CinematicId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.CinematicId = reader.ReadVarShort();
	}
}
}
