


















// Generated on 06/26/2015 11:41:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AccountLoggingKickedMessage : NetworkMessage
{

public const uint Id = 6029;
public override uint MessageId
{
    get { return Id; }
}

public ushort days;
        public sbyte hours;
        public sbyte minutes;
        

public AccountLoggingKickedMessage()
{
}

public AccountLoggingKickedMessage(ushort days, sbyte hours, sbyte minutes)
        {
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(days);
            writer.WriteSByte(hours);
            writer.WriteSByte(minutes);
            

}

public override void Deserialize(ICustomDataReader reader)
{

days = reader.ReadVaruhshort();
            if (days < 0)
                throw new Exception("Forbidden value on days = " + days + ", it doesn't respect the following condition : days < 0");
            hours = reader.ReadSByte();
            if (hours < 0)
                throw new Exception("Forbidden value on hours = " + hours + ", it doesn't respect the following condition : hours < 0");
            minutes = reader.ReadSByte();
            if (minutes < 0)
                throw new Exception("Forbidden value on minutes = " + minutes + ", it doesn't respect the following condition : minutes < 0");
            

}


}


}