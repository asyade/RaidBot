


















// Generated on 06/26/2015 11:41:04
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightSummonMessage : AbstractGameActionMessage
{

public const uint Id = 5825;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameFightFighterInformations summon;
        

public GameActionFightSummonMessage()
{
}

public GameActionFightSummonMessage(ushort actionId, int sourceId, Types.GameFightFighterInformations summon)
         : base(actionId, sourceId)
        {
            this.summon = summon;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(summon.TypeId);
            summon.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            summon = Types.ProtocolTypeManager.GetInstance<Types.GameFightFighterInformations>(reader.ReadShort());
            summon.Deserialize(reader);
            

}


}


}