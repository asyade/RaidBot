using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameEntityDispositionMessage : NetworkMessage
{

	public const uint Id = 5693;
	public override uint MessageId { get { return Id; } }

	public IdentifiedEntityDispositionInformations Disposition { get; set; }

	public GameEntityDispositionMessage() {}


	public GameEntityDispositionMessage InitGameEntityDispositionMessage(IdentifiedEntityDispositionInformations Disposition)
	{
		this.Disposition = Disposition;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.Disposition.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Disposition = new IdentifiedEntityDispositionInformations();
		this.Disposition.Deserialize(reader);
	}
}
}
