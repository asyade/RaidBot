using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayMountInformations : GameRolePlayNamedActorInformations
{

	public const uint Id = 180;
	public override uint MessageId { get { return Id; } }

	public String OwnerName { get; set; }
	public byte Level { get; set; }

	public GameRolePlayMountInformations() {}


	public GameRolePlayMountInformations InitGameRolePlayMountInformations(String OwnerName, byte Level)
	{
		this.OwnerName = OwnerName;
		this.Level = Level;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteUTF(this.OwnerName);
		writer.WriteByte(this.Level);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.OwnerName = reader.ReadUTF();
		this.Level = reader.ReadByte();
	}
}
}
