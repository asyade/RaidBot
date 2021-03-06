using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class JobCrafterDirectoryDefineSettingsMessage : NetworkMessage
{

	public const uint Id = 5649;
	public override uint MessageId { get { return Id; } }

	public JobCrafterDirectorySettings Settings { get; set; }

	public JobCrafterDirectoryDefineSettingsMessage() {}


	public JobCrafterDirectoryDefineSettingsMessage InitJobCrafterDirectoryDefineSettingsMessage(JobCrafterDirectorySettings Settings)
	{
		this.Settings = Settings;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.Settings.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Settings = new JobCrafterDirectorySettings();
		this.Settings.Deserialize(reader);
	}
}
}
