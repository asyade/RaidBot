


















// Generated on 06/26/2015 11:42:11
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class VersionExtended : Version
{

public const short Id = 393;
public override short TypeId
{
    get { return Id; }
}

public byte install;
        public byte technology;
        

public VersionExtended()
{
}

public VersionExtended(byte major, byte minor, byte release, int revision, byte patch, byte buildType, byte install, byte technology)
         : base(major, minor, release, revision, patch, buildType)
        {
            this.install = install;
            this.technology = technology;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteByte(install);
            writer.WriteByte(technology);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            install = reader.ReadByte();
            if (install < 0)
                throw new Exception("Forbidden value on install = " + install + ", it doesn't respect the following condition : install < 0");
            technology = reader.ReadByte();
            if (technology < 0)
                throw new Exception("Forbidden value on technology = " + technology + ", it doesn't respect the following condition : technology < 0");
            

}


}


}