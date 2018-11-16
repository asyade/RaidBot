


















// Generated on 06/26/2015 11:41:19
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MountEquipedErrorMessage : NetworkMessage
{

public const uint Id = 5963;
public override uint MessageId
{
    get { return Id; }
}

public sbyte errorType;
        

public MountEquipedErrorMessage()
{
}

public MountEquipedErrorMessage(sbyte errorType)
        {
            this.errorType = errorType;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(errorType);
            

}

public override void Deserialize(ICustomDataReader reader)
{

errorType = reader.ReadSByte();
            if (errorType < 0)
                throw new Exception("Forbidden value on errorType = " + errorType + ", it doesn't respect the following condition : errorType < 0");
            

}


}


}