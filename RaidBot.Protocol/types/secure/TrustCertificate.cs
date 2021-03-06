using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TrustCertificate : NetworkType
{

	public const uint Id = 377;
	public override uint MessageId { get { return Id; } }

	public int Id_ { get; set; }
	public String Hash { get; set; }

	public TrustCertificate() {}


	public TrustCertificate InitTrustCertificate(int Id_, String Hash)
	{
		this.Id_ = Id_;
		this.Hash = Hash;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.Id_);
		writer.WriteUTF(this.Hash);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Id_ = reader.ReadInt();
		this.Hash = reader.ReadUTF();
	}
}
}
