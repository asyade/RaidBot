


















// Generated on 06/26/2015 11:42:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class ObjectEffectDuration : ObjectEffect
{

public const short Id = 75;
public override short TypeId
{
    get { return Id; }
}

public ushort days;
        public sbyte hours;
        public sbyte minutes;
        

public ObjectEffectDuration()
{
}

public ObjectEffectDuration(ushort actionId, ushort days, sbyte hours, sbyte minutes)
         : base(actionId)
        {
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(days);
            writer.WriteSByte(hours);
            writer.WriteSByte(minutes);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
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