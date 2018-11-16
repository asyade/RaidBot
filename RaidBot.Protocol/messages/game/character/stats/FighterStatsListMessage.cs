


















// Generated on 06/26/2015 11:41:10
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class FighterStatsListMessage : NetworkMessage
{

public const uint Id = 6322;
public override uint MessageId
{
    get { return Id; }
}

public Types.CharacterCharacteristicsInformations stats;
        

public FighterStatsListMessage()
{
}

public FighterStatsListMessage(Types.CharacterCharacteristicsInformations stats)
        {
            this.stats = stats;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

stats.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

stats = new Types.CharacterCharacteristicsInformations();
            stats.Deserialize(reader);
            

}


}


}