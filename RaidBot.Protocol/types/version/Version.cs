


















// Generated on 06/26/2015 11:42:11
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class Version
{

public const short Id = 11;
public virtual short TypeId
{
    get { return Id; }
}

public byte major;
        public byte minor;
        public byte release;
        public int revision;
        public byte patch;
        public byte buildType;
        

public Version()
{
}

public Version(byte major, byte minor, byte release, int revision, byte patch, byte buildType)
        {
            this.major = major;
            this.minor = minor;
            this.release = release;
            this.revision = revision;
            this.patch = patch;
            this.buildType = buildType;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

            writer.WriteByte(major);
            writer.WriteByte(minor);
            writer.WriteByte(release);
            writer.WriteInt(revision);
            writer.WriteByte(patch);
            writer.WriteByte(buildType);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{
            major = reader.ReadByte();
            minor = reader.ReadByte();
            release = reader.ReadByte();
            revision = reader.ReadInt();
            patch = reader.ReadByte();
            buildType = reader.ReadByte();
}
}
}