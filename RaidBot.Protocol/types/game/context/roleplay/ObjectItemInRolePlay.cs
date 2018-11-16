


















// Generated on 06/26/2015 11:42:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class ObjectItemInRolePlay
{

public const short Id = 198;
public virtual short TypeId
{
    get { return Id; }
}

public ushort cellId;
        public ushort objectGID;
        

public ObjectItemInRolePlay()
{
}

public ObjectItemInRolePlay(ushort cellId, ushort objectGID)
        {
            this.cellId = cellId;
            this.objectGID = objectGID;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(cellId);
            writer.WriteVaruhshort(objectGID);
            

}

public virtual void Deserialize(ICustomDataReader reader)
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