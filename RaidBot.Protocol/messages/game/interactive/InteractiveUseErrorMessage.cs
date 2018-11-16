


















// Generated on 06/26/2015 11:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class InteractiveUseErrorMessage : NetworkMessage
{

public const uint Id = 6384;
public override uint MessageId
{
    get { return Id; }
}

public uint elemId;
        public uint skillInstanceUid;
        

public InteractiveUseErrorMessage()
{
}

public InteractiveUseErrorMessage(uint elemId, uint skillInstanceUid)
        {
            this.elemId = elemId;
            this.skillInstanceUid = skillInstanceUid;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(elemId);
            writer.WriteVaruhint(skillInstanceUid);
            

}

public override void Deserialize(ICustomDataReader reader)
{

elemId = reader.ReadVaruhint();
            if (elemId < 0)
                throw new Exception("Forbidden value on elemId = " + elemId + ", it doesn't respect the following condition : elemId < 0");
            skillInstanceUid = reader.ReadVaruhint();
            if (skillInstanceUid < 0)
                throw new Exception("Forbidden value on skillInstanceUid = " + skillInstanceUid + ", it doesn't respect the following condition : skillInstanceUid < 0");
            

}


}


}