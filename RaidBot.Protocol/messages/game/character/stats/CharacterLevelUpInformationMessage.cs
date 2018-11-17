using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CharacterLevelUpInformationMessage : CharacterLevelUpMessage
{

	public const uint Id = 6076;
	public override uint MessageId { get { return Id; } }

	public String Name { get; set; }
	public long Id_ { get; set; }

	public CharacterLevelUpInformationMessage() {}


	public CharacterLevelUpInformationMessage InitCharacterLevelUpInformationMessage(String Name, long Id_)
	{
		this.Name = Name;
		this.Id_ = Id_;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteUTF(this.Name);
		writer.WriteVarLong(this.Id_);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Name = reader.ReadUTF();
		this.Id_ = reader.ReadVarLong();
	}
}
}
