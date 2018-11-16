


















// Generated on 06/26/2015 11:42:01
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class CharacterHardcoreOrEpicInformations : CharacterBaseInformations
{

public const short Id = 474;
public override short TypeId
{
    get { return Id; }
}

public sbyte deathState;
        public ushort deathCount;
        public byte deathMaxLevel;
        

public CharacterHardcoreOrEpicInformations()
{
}

public CharacterHardcoreOrEpicInformations(uint id, byte level, string name, Types.EntityLook entityLook, sbyte breed, bool sex, sbyte deathState, ushort deathCount, byte deathMaxLevel)
         : base(id, level, name, entityLook, breed, sex)
        {
            this.deathState = deathState;
            this.deathCount = deathCount;
            this.deathMaxLevel = deathMaxLevel;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(deathState);
            writer.WriteVaruhshort(deathCount);
            writer.WriteByte(deathMaxLevel);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            deathState = reader.ReadSByte();
            if (deathState < 0)
                throw new Exception("Forbidden value on deathState = " + deathState + ", it doesn't respect the following condition : deathState < 0");
            deathCount = reader.ReadVaruhshort();
            if (deathCount < 0)
                throw new Exception("Forbidden value on deathCount = " + deathCount + ", it doesn't respect the following condition : deathCount < 0");
            deathMaxLevel = reader.ReadByte();
            if (deathMaxLevel < 1 || deathMaxLevel > 200)
                throw new Exception("Forbidden value on deathMaxLevel = " + deathMaxLevel + ", it doesn't respect the following condition : deathMaxLevel < 1 || deathMaxLevel > 200");
            

}


}


}