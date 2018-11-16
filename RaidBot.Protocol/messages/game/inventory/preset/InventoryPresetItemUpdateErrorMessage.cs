


















// Generated on 06/26/2015 11:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class InventoryPresetItemUpdateErrorMessage : NetworkMessage
{

public const uint Id = 6211;
public override uint MessageId
{
    get { return Id; }
}

public sbyte code;
        

public InventoryPresetItemUpdateErrorMessage()
{
}

public InventoryPresetItemUpdateErrorMessage(sbyte code)
        {
            this.code = code;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(code);
            

}

public override void Deserialize(ICustomDataReader reader)
{

code = reader.ReadSByte();
            if (code < 0)
                throw new Exception("Forbidden value on code = " + code + ", it doesn't respect the following condition : code < 0");
            

}


}


}