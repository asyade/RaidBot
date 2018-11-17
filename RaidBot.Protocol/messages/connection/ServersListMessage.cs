using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ServersListMessage : NetworkMessage
{

	public const uint Id = 30;
	public override uint MessageId { get { return Id; } }

	public GameServerInformations[] Servers { get; set; }
	public short AlreadyConnectedToServerId { get; set; }
	public bool CanCreateNewCharacter { get; set; }

	public ServersListMessage() {}


	public ServersListMessage InitServersListMessage(GameServerInformations[] Servers, short AlreadyConnectedToServerId, bool CanCreateNewCharacter)
	{
		this.Servers = Servers;
		this.AlreadyConnectedToServerId = AlreadyConnectedToServerId;
		this.CanCreateNewCharacter = CanCreateNewCharacter;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.Servers.Length);
		foreach (GameServerInformations item in this.Servers)
		{
			item.Serialize(writer);
		}
		writer.WriteVarShort(this.AlreadyConnectedToServerId);
		writer.WriteBoolean(this.CanCreateNewCharacter);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		int ServersLen = reader.ReadShort();
		Servers = new GameServerInformations[ServersLen];
		for (int i = 0; i < ServersLen; i++)
		{
			this.Servers[i] = new GameServerInformations();
			this.Servers[i].Deserialize(reader);
		}
		this.AlreadyConnectedToServerId = reader.ReadVarShort();
		this.CanCreateNewCharacter = reader.ReadBoolean();
	}
}
}
