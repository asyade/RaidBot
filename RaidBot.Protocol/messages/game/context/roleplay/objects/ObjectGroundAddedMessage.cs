


















// Generated on 06/26/2015 11:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ObjectGroundAddedMessage : NetworkMessage
{

public const uint Id = 3017;
public override uint MessageId
{
    get { return Id; }
}

public ushort cellId;
        public ushort objectGID;
        

public ObjectGroundAddedMessage()
{
}

public ObjectGroundAddedMessage(ushort cellId, ushort objectGID)
        {
            this.cellId = cellId;
            this.objectGID = objectGID;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(cellId);
            writer.WriteVaruhshort(objectGID);
            

}

public override void Deserialize(ICustomDataReader reader)
{

cellId = reader.ReadVaruhshort();
            if (cellId < 0 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
            objectGID = reader.ReadVaruhshort();
            if (objectGID < 0)
                throw new Exception("Forbidden value on objectGID = " + objectGID + ", it doesn't respect the following condition : objectGID < 0");
            

}


}


}