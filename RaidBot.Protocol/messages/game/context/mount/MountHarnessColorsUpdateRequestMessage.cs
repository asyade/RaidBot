using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MountHarnessColorsUpdateRequestMessage : NetworkMessage
{

	public const uint Id = 6697;
	public override uint MessageId { get { return Id; } }

	public bool UseHarnessColors { get; set; }

	public MountHarnessColorsUpdateRequestMessage() {}


	public MountHarnessColorsUpdateRequestMessage InitMountHarnessColorsUpdateRequestMessage(bool UseHarnessColors)
	{
		this.UseHarnessColors = UseHarnessColors;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.UseHarnessColors);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.UseHarnessColors = reader.ReadBoolean();
	}
}
}
