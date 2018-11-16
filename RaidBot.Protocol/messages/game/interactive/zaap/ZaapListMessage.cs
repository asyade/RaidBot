


















// Generated on 06/26/2015 11:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ZaapListMessage : TeleportDestinationsListMessage
{

public const uint Id = 1604;
public override uint MessageId
{
    get { return Id; }
}

public int spawnMapId;
        

public ZaapListMessage()
{
}

public ZaapListMessage(sbyte teleporterType, int[] mapIds, ushort[] subAreaIds, ushort[] costs, sbyte[] destTeleporterType, int spawnMapId)
         : base(teleporterType, mapIds, subAreaIds, costs, destTeleporterType)
        {
            this.spawnMapId = spawnMapId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(spawnMapId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            spawnMapId = reader.ReadInt();
            if (spawnMapId < 0)
                throw new Exception("Forbidden value on spawnMapId = " + spawnMapId + ", it doesn't respect the following condition : spawnMapId < 0");
            

}


}


}