


















// Generated on 06/26/2015 11:41:00
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AchievementFinishedInformationMessage : AchievementFinishedMessage
{

public const uint Id = 6381;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        public uint playerId;
        

public AchievementFinishedInformationMessage()
{
}

public AchievementFinishedInformationMessage(ushort id, byte finishedlevel, string name, uint playerId)
         : base(id, finishedlevel)
        {
            this.name = name;
            this.playerId = playerId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteVaruhint(playerId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            playerId = reader.ReadVaruhint();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            

}


}


}