


















// Generated on 06/26/2015 11:41:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class KohUpdateMessage : NetworkMessage
{

public const uint Id = 6439;
public override uint MessageId
{
    get { return Id; }
}

public Types.AllianceInformations[] alliances;
        public ushort[] allianceNbMembers;
        public uint[] allianceRoundWeigth;
        public sbyte[] allianceMatchScore;
        public Types.BasicAllianceInformations allianceMapWinner;
        public uint allianceMapWinnerScore;
        public uint allianceMapMyAllianceScore;
        public double nextTickTime;
        

public KohUpdateMessage()
{
}

public KohUpdateMessage(Types.AllianceInformations[] alliances, ushort[] allianceNbMembers, uint[] allianceRoundWeigth, sbyte[] allianceMatchScore, Types.BasicAllianceInformations allianceMapWinner, uint allianceMapWinnerScore, uint allianceMapMyAllianceScore, double nextTickTime)
        {
            this.alliances = alliances;
            this.allianceNbMembers = allianceNbMembers;
            this.allianceRoundWeigth = allianceRoundWeigth;
            this.allianceMatchScore = allianceMatchScore;
            this.allianceMapWinner = allianceMapWinner;
            this.allianceMapWinnerScore = allianceMapWinnerScore;
            this.allianceMapMyAllianceScore = allianceMapMyAllianceScore;
            this.nextTickTime = nextTickTime;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)alliances.Length);
            foreach (var entry in alliances)
            {
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)allianceNbMembers.Length);
            foreach (var entry in allianceNbMembers)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteUShort((ushort)allianceRoundWeigth.Length);
            foreach (var entry in allianceRoundWeigth)
            {
                 writer.WriteVaruhint(entry);
            }
            writer.WriteUShort((ushort)allianceMatchScore.Length);
            foreach (var entry in allianceMatchScore)
            {
                 writer.WriteSByte(entry);
            }
            allianceMapWinner.Serialize(writer);
            writer.WriteVaruhint(allianceMapWinnerScore);
            writer.WriteVaruhint(allianceMapMyAllianceScore);
            writer.WriteDouble(nextTickTime);
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            alliances = new Types.AllianceInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 alliances[i] = new Types.AllianceInformations();
                 alliances[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            allianceNbMembers = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 allianceNbMembers[i] = reader.ReadVaruhshort();
            }
            limit = reader.ReadUShort();
            allianceRoundWeigth = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 allianceRoundWeigth[i] = reader.ReadVaruhint();
            }
            limit = reader.ReadUShort();
            allianceMatchScore = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 allianceMatchScore[i] = reader.ReadSByte();
            }
            allianceMapWinner = new Types.BasicAllianceInformations();
            allianceMapWinner.Deserialize(reader);
            allianceMapWinnerScore = reader.ReadVaruhint();
            if (allianceMapWinnerScore < 0)
                throw new Exception("Forbidden value on allianceMapWinnerScore = " + allianceMapWinnerScore + ", it doesn't respect the following condition : allianceMapWinnerScore < 0");
            allianceMapMyAllianceScore = reader.ReadVaruhint();
            if (allianceMapMyAllianceScore < 0)
                throw new Exception("Forbidden value on allianceMapMyAllianceScore = " + allianceMapMyAllianceScore + ", it doesn't respect the following condition : allianceMapMyAllianceScore < 0");
            nextTickTime = reader.ReadDouble();
            if (nextTickTime < 0 || nextTickTime > 9.007199254740992E15)
                throw new Exception("Forbidden value on nextTickTime = " + nextTickTime + ", it doesn't respect the following condition : nextTickTime < 0 || nextTickTime > 9.007199254740992E15");
            

}


}


}