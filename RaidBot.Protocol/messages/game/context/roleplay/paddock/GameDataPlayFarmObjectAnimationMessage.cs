


















// Generated on 06/26/2015 11:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameDataPlayFarmObjectAnimationMessage : NetworkMessage
{

public const uint Id = 6026;
public override uint MessageId
{
    get { return Id; }
}

public ushort[] cellId;
        

public GameDataPlayFarmObjectAnimationMessage()
{
}

public GameDataPlayFarmObjectAnimationMessage(ushort[] cellId)
        {
            this.cellId = cellId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)cellId.Length);
            foreach (var entry in cellId)
            {
                 writer.WriteVaruhshort(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            cellId = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 cellId[i] = reader.ReadVaruhshort();
            }
            

}


}


}