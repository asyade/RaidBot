using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class DareCreationRequestMessage : NetworkMessage
{

	public const uint Id = 6665;
	public override uint MessageId { get { return Id; } }

	public bool IsPrivate { get; set; }
	public bool IsForGuild { get; set; }
	public bool IsForAlliance { get; set; }
	public bool NeedNotifications { get; set; }
	public long SubscriptionFee { get; set; }
	public long Jackpot { get; set; }
	public short MaxCountWinners { get; set; }
	public uint DelayBeforeStart { get; set; }
	public uint Duration { get; set; }
	public DareCriteria[] Criterions { get; set; }

	public DareCreationRequestMessage() {}


	public DareCreationRequestMessage InitDareCreationRequestMessage(bool IsPrivate, bool IsForGuild, bool IsForAlliance, bool NeedNotifications, long SubscriptionFee, long Jackpot, short MaxCountWinners, uint DelayBeforeStart, uint Duration, DareCriteria[] Criterions)
	{
		this.IsPrivate = IsPrivate;
		this.IsForGuild = IsForGuild;
		this.IsForAlliance = IsForAlliance;
		this.NeedNotifications = NeedNotifications;
		this.SubscriptionFee = SubscriptionFee;
		this.Jackpot = Jackpot;
		this.MaxCountWinners = MaxCountWinners;
		this.DelayBeforeStart = DelayBeforeStart;
		this.Duration = Duration;
		this.Criterions = Criterions;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		byte box = 0;
		box = BooleanByteWrapper.SetFlag(box, 0, IsPrivate);
		box = BooleanByteWrapper.SetFlag(box, 1, IsForGuild);
		box = BooleanByteWrapper.SetFlag(box, 2, IsForAlliance);
		box = BooleanByteWrapper.SetFlag(box, 3, NeedNotifications);
		writer.WriteByte(box);
		writer.WriteVarLong(this.SubscriptionFee);
		writer.WriteVarLong(this.Jackpot);
		writer.WriteShort(this.MaxCountWinners);
		writer.WriteUnsignedInt(this.DelayBeforeStart);
		writer.WriteUnsignedInt(this.Duration);
		writer.WriteShort(this.Criterions.Length);
		foreach (DareCriteria item in this.Criterions)
		{
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		byte box = reader.ReadByte();
		this.IsPrivate = BooleanByteWrapper.GetFlag(box, 0);
		this.IsForGuild = BooleanByteWrapper.GetFlag(box, 1);
		this.IsForAlliance = BooleanByteWrapper.GetFlag(box, 2);
		this.NeedNotifications = BooleanByteWrapper.GetFlag(box, 3);
		this.SubscriptionFee = reader.ReadVarLong();
		this.Jackpot = reader.ReadVarLong();
		this.MaxCountWinners = reader.ReadShort();
		this.DelayBeforeStart = reader.ReadUnsignedInt();
		this.Duration = reader.ReadUnsignedInt();
		int CriterionsLen = reader.ReadShort();
		Criterions = new DareCriteria[CriterionsLen];
		for (int i = 0; i < CriterionsLen; i++)
		{
			this.Criterions[i] = new DareCriteria();
			this.Criterions[i].Deserialize(reader);
		}
	}
}
}
