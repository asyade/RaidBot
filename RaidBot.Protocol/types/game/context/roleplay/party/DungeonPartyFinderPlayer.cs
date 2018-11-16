


















// Generated on 06/26/2015 11:42:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class DungeonPartyFinderPlayer
{

public const short Id = 373;
public virtual short TypeId
{
    get { return Id; }
}

public uint playerId;
        public string playerName;
        public sbyte breed;
        public bool sex;
        public byte level;
        

public DungeonPartyFinderPlayer()
{
}

public DungeonPartyFinderPlayer(uint playerId, string playerName, sbyte breed, bool sex, byte level)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.breed = breed;
            this.sex = sex;
            this.level = level;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(playerId);
            writer.WriteUTF(playerName);
            writer.WriteSByte(breed);
            writer.WriteBoolean(sex);
            writer.WriteByte(level);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

playerId = reader.ReadVaruhint();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            playerName = reader.ReadUTF();
            breed = reader.ReadSByte();
            if (breed < (byte)Enums.PlayableBreedEnum.Feca || breed > (byte)Enums.PlayableBreedEnum.Eliotrope)
                throw new Exception("Forbidden value on breed = " + breed + ", it doesn't respect the following condition : breed < (byte)Enums.PlayableBreedEnum.Feca || breed > (byte)Enums.PlayableBreedEnum.Eliotrope");
            sex = reader.ReadBoolean();
            level = reader.ReadByte();
            if (level < 0 || level > 255)
                throw new Exception("Forbidden value on level = " + level + ", it doesn't respect the following condition : level < 0 || level > 255");
            

}


}


}