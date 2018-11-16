


















// Generated on 06/26/2015 11:41:21
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MapComplementaryInformationsWithCoordsMessage : MapComplementaryInformationsDataMessage
{

public const uint Id = 6268;
public override uint MessageId
{
    get { return Id; }
}

public short worldX;
        public short worldY;
        

public MapComplementaryInformationsWithCoordsMessage()
{
}

public MapComplementaryInformationsWithCoordsMessage(ushort subAreaId, int mapId, Types.HouseInformations[] houses, Types.GameRolePlayActorInformations[] actors, Types.InteractiveElement[] interactiveElements, Types.StatedElement[] statedElements, Types.MapObstacle[] obstacles, Types.FightCommonInformations[] fights, short worldX, short worldY)
         : base(subAreaId, mapId, houses, actors, interactiveElements, statedElements, obstacles, fights)
        {
            this.worldX = worldX;
            this.worldY = worldY;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            worldX = reader.ReadShort();
            if (worldX < -255 || worldX > 255)
                throw new Exception("Forbidden value on worldX = " + worldX + ", it doesn't respect the following condition : worldX < -255 || worldX > 255");
            worldY = reader.ReadShort();
            if (worldY < -255 || worldY > 255)
                throw new Exception("Forbidden value on worldY = " + worldY + ", it doesn't respect the following condition : worldY < -255 || worldY > 255");
            

}


}


}