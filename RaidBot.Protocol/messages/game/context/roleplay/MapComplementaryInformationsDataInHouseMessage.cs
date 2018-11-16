


















// Generated on 06/26/2015 11:41:21
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MapComplementaryInformationsDataInHouseMessage : MapComplementaryInformationsDataMessage
{

public const uint Id = 6130;
public override uint MessageId
{
    get { return Id; }
}

public Types.HouseInformationsInside currentHouse;
        

public MapComplementaryInformationsDataInHouseMessage()
{
}

public MapComplementaryInformationsDataInHouseMessage(ushort subAreaId, int mapId, Types.HouseInformations[] houses, Types.GameRolePlayActorInformations[] actors, Types.InteractiveElement[] interactiveElements, Types.StatedElement[] statedElements, Types.MapObstacle[] obstacles, Types.FightCommonInformations[] fights, Types.HouseInformationsInside currentHouse)
         : base(subAreaId, mapId, houses, actors, interactiveElements, statedElements, obstacles, fights)
        {
            this.currentHouse = currentHouse;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            currentHouse.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            currentHouse = new Types.HouseInformationsInside();
            currentHouse.Deserialize(reader);
            

}


}


}