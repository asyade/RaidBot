using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildFactsMessage : NetworkMessage
{

	public const uint Id = 6415;
	public override uint MessageId { get { return Id; } }

	public int CreationDate { get; set; }
	public short NbTaxCollectors { get; set; }
	public CharacterMinimalInformations[] Members { get; set; }

	public GuildFactsMessage() {}


	public GuildFactsMessage InitGuildFactsMessage(int CreationDate, short NbTaxCollectors, CharacterMinimalInformations[] Members)
	{
		this.CreationDate = CreationDate;
		this.NbTaxCollectors = NbTaxCollectors;
		this.Members = Members;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.CreationDate);
		writer.WriteVarShort(this.NbTaxCollectors);
		writer.WriteShort(this.Members.Length);
		foreach (CharacterMinimalInformations item in this.Members)
		{
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.CreationDate = reader.ReadInt();
		this.NbTaxCollectors = reader.ReadVarShort();
		int MembersLen = reader.ReadShort();
		Members = new CharacterMinimalInformations[MembersLen];
		for (int i = 0; i < MembersLen; i++)
		{
			this.Members[i] = new CharacterMinimalInformations();
			this.Members[i].Deserialize(reader);
		}
	}
}
}
