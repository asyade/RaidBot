


















// Generated on 06/26/2015 11:41:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class BasicDateMessage : NetworkMessage
{

public const uint Id = 177;
public override uint MessageId
{
    get { return Id; }
}

public sbyte day;
        public sbyte month;
        public short year;
        

public BasicDateMessage()
{
}

public BasicDateMessage(sbyte day, sbyte month, short year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(day);
            writer.WriteSByte(month);
            writer.WriteShort(year);
            

}

public override void Deserialize(ICustomDataReader reader)
{

day = reader.ReadSByte();
            if (day < 0)
                throw new Exception("Forbidden value on day = " + day + ", it doesn't respect the following condition : day < 0");
            month = reader.ReadSByte();
            if (month < 0)
                throw new Exception("Forbidden value on month = " + month + ", it doesn't respect the following condition : month < 0");
            year = reader.ReadShort();
            if (year < 0)
                throw new Exception("Forbidden value on year = " + year + ", it doesn't respect the following condition : year < 0");
            

}


}


}