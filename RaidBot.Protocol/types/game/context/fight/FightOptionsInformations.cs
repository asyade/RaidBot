using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FightOptionsInformations : NetworkType
{

	public const uint Id = 20;
	public override uint MessageId { get { return Id; } }

	public bool IsSecret { get; set; }
	public bool IsRestrictedToPartyOnly { get; set; }
	public bool IsClosed { get; set; }
	public bool IsAskingForHelp { get; set; }

	public FightOptionsInformations() {}


	public FightOptionsInformations InitFightOptionsInformations(bool IsSecret, bool IsRestrictedToPartyOnly, bool IsClosed, bool IsAskingForHelp)
	{
		this.IsSecret = IsSecret;
		this.IsRestrictedToPartyOnly = IsRestrictedToPartyOnly;
		this.IsClosed = IsClosed;
		this.IsAskingForHelp = IsAskingForHelp;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		byte box = 0;
		box = BooleanByteWrapper.SetFlag(box, 0, IsSecret);
		box = BooleanByteWrapper.SetFlag(box, 1, IsRestrictedToPartyOnly);
		box = BooleanByteWrapper.SetFlag(box, 2, IsClosed);
		box = BooleanByteWrapper.SetFlag(box, 3, IsAskingForHelp);
		writer.WriteByte(box);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		byte box = reader.ReadByte();
		this.IsSecret = BooleanByteWrapper.GetFlag(box, 0);
		this.IsRestrictedToPartyOnly = BooleanByteWrapper.GetFlag(box, 1);
		this.IsClosed = BooleanByteWrapper.GetFlag(box, 2);
		this.IsAskingForHelp = BooleanByteWrapper.GetFlag(box, 3);
	}
}
}
