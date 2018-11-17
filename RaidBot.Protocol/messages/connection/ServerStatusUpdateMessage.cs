using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ServerStatusUpdateMessage : NetworkMessage
{

	public const uint Id = 50;
	public override uint MessageId { get { return Id; } }

	public GameServerInformations Server { get; set; }

	public ServerStatusUpdateMessage() {}


	public ServerStatusUpdateMessage InitServerStatusUpdateMessage(GameServerInformations Server)
	{
		this.Server = Server;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.Server.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Server = new GameServerInformations();
		this.Server.Deserialize(reader);
	}
}
}
