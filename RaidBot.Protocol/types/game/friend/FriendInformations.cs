


















// Generated on 06/26/2015 11:42:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class FriendInformations : AbstractContactInformations
{

public const short Id = 78;
public override short TypeId
{
    get { return Id; }
}

public sbyte playerState;
        public ushort lastConnection;
        public int achievementPoints;
        

public FriendInformations()
{
}

public FriendInformations(int accountId, string accountName, sbyte playerState, ushort lastConnection, int achievementPoints)
         : base(accountId, accountName)
        {
            this.playerState = playerState;
            this.lastConnection = lastConnection;
            this.achievementPoints = achievementPoints;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(playerState);
            writer.WriteVaruhshort(lastConnection);
            writer.WriteInt(achievementPoints);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            playerState = reader.ReadSByte();
            if (playerState < 0)
                throw new Exception("Forbidden value on playerState = " + playerState + ", it doesn't respect the following condition : playerState < 0");
            lastConnection = reader.ReadVaruhshort();
            if (lastConnection < 0)
                throw new Exception("Forbidden value on lastConnection = " + lastConnection + ", it doesn't respect the following condition : lastConnection < 0");
            achievementPoints = reader.ReadInt();
            

}


}


}