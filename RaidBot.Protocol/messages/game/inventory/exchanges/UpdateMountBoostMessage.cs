


















// Generated on 06/26/2015 11:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class UpdateMountBoostMessage : NetworkMessage
{

public const uint Id = 6179;
public override uint MessageId
{
    get { return Id; }
}

public int rideId;
        public Types.UpdateMountBoost[] boostToUpdateList;
        

public UpdateMountBoostMessage()
{
}

public UpdateMountBoostMessage(int rideId, Types.UpdateMountBoost[] boostToUpdateList)
        {
            this.rideId = rideId;
            this.boostToUpdateList = boostToUpdateList;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVarint(rideId);
            writer.WriteUShort((ushort)boostToUpdateList.Length);
            foreach (var entry in boostToUpdateList)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

rideId = reader.ReadVarint();
            var limit = reader.ReadUShort();
            boostToUpdateList = new Types.UpdateMountBoost[limit];
            for (int i = 0; i < limit; i++)
            {
                 boostToUpdateList[i] = Types.ProtocolTypeManager.GetInstance<Types.UpdateMountBoost>(reader.ReadShort());
                 boostToUpdateList[i].Deserialize(reader);
            }
            

}


}


}