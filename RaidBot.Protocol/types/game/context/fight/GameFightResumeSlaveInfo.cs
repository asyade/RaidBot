


















// Generated on 06/26/2015 11:42:04
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GameFightResumeSlaveInfo
{

public const short Id = 364;
public virtual short TypeId
{
    get { return Id; }
}

public int slaveId;
        public Types.GameFightSpellCooldown[] spellCooldowns;
        public sbyte summonCount;
        public sbyte bombCount;
        

public GameFightResumeSlaveInfo()
{
}

public GameFightResumeSlaveInfo(int slaveId, Types.GameFightSpellCooldown[] spellCooldowns, sbyte summonCount, sbyte bombCount)
        {
            this.slaveId = slaveId;
            this.spellCooldowns = spellCooldowns;
            this.summonCount = summonCount;
            this.bombCount = bombCount;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(slaveId);
            writer.WriteUShort((ushort)spellCooldowns.Length);
            foreach (var entry in spellCooldowns)
            {
                 entry.Serialize(writer);
            }
            writer.WriteSByte(summonCount);
            writer.WriteSByte(bombCount);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

slaveId = reader.ReadInt();
            var limit = reader.ReadUShort();
            spellCooldowns = new Types.GameFightSpellCooldown[limit];
            for (int i = 0; i < limit; i++)
            {
                 spellCooldowns[i] = new Types.GameFightSpellCooldown();
                 spellCooldowns[i].Deserialize(reader);
            }
            summonCount = reader.ReadSByte();
            if (summonCount < 0)
                throw new Exception("Forbidden value on summonCount = " + summonCount + ", it doesn't respect the following condition : summonCount < 0");
            bombCount = reader.ReadSByte();
            if (bombCount < 0)
                throw new Exception("Forbidden value on bombCount = " + bombCount + ", it doesn't respect the following condition : bombCount < 0");
            

}


}


}