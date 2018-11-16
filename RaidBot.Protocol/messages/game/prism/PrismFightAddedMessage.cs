


















// Generated on 06/26/2015 11:41:54
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PrismFightAddedMessage : NetworkMessage
{

public const uint Id = 6452;
public override uint MessageId
{
    get { return Id; }
}

public Types.PrismFightersInformation fight;
        

public PrismFightAddedMessage()
{
}

public PrismFightAddedMessage(Types.PrismFightersInformation fight)
        {
            this.fight = fight;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

fight.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

fight = new Types.PrismFightersInformation();
            fight.Deserialize(reader);
            

}


}


}