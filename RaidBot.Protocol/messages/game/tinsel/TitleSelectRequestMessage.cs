


















// Generated on 06/26/2015 11:41:57
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TitleSelectRequestMessage : NetworkMessage
{

public const uint Id = 6365;
public override uint MessageId
{
    get { return Id; }
}

public ushort titleId;
        

public TitleSelectRequestMessage()
{
}

public TitleSelectRequestMessage(ushort titleId)
        {
            this.titleId = titleId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(titleId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

titleId = reader.ReadVaruhshort();
            if (titleId < 0)
                throw new Exception("Forbidden value on titleId = " + titleId + ", it doesn't respect the following condition : titleId < 0");
            

}


}


}