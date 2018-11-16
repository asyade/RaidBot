


















// Generated on 06/26/2015 11:41:16
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightPlacementPossiblePositionsMessage : NetworkMessage
{

public const uint Id = 703;
public override uint MessageId
{
    get { return Id; }
}

public ushort[] positionsForChallengers;
        public ushort[] positionsForDefenders;
        public sbyte teamNumber;
        

public GameFightPlacementPossiblePositionsMessage()
{
}

public GameFightPlacementPossiblePositionsMessage(ushort[] positionsForChallengers, ushort[] positionsForDefenders, sbyte teamNumber)
        {
            this.positionsForChallengers = positionsForChallengers;
            this.positionsForDefenders = positionsForDefenders;
            this.teamNumber = teamNumber;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)positionsForChallengers.Length);
            foreach (var entry in positionsForChallengers)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteUShort((ushort)positionsForDefenders.Length);
            foreach (var entry in positionsForDefenders)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteSByte(teamNumber);
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            positionsForChallengers = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 positionsForChallengers[i] = reader.ReadVaruhshort();
            }
            limit = reader.ReadUShort();
            positionsForDefenders = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 positionsForDefenders[i] = reader.ReadVaruhshort();
            }
            teamNumber = reader.ReadSByte();
            if (teamNumber < 0)
                throw new Exception("Forbidden value on teamNumber = " + teamNumber + ", it doesn't respect the following condition : teamNumber < 0");
            

}


}


}