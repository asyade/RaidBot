


















// Generated on 06/26/2015 11:41:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AlmanachCalendarDateMessage : NetworkMessage
{

public const uint Id = 6341;
public override uint MessageId
{
    get { return Id; }
}

public int date;
        

public AlmanachCalendarDateMessage()
{
}

public AlmanachCalendarDateMessage(int date)
        {
            this.date = date;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(date);
            

}

public override void Deserialize(ICustomDataReader reader)
{

date = reader.ReadInt();
            

}


}


}