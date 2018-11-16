


















// Generated on 06/26/2015 11:41:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class CompassUpdatePvpSeekMessage : CompassUpdateMessage
{

public const uint Id = 6013;
public override uint MessageId
{
    get { return Id; }
}

public uint memberId;
        public string memberName;
        

public CompassUpdatePvpSeekMessage()
{
}

public CompassUpdatePvpSeekMessage(sbyte type, Types.MapCoordinates coords, uint memberId, string memberName)
         : base(type, coords)
        {
            this.memberId = memberId;
            this.memberName = memberName;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(memberId);
            writer.WriteUTF(memberName);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            memberId = reader.ReadVaruhint();
            if (memberId < 0)
                throw new Exception("Forbidden value on memberId = " + memberId + ", it doesn't respect the following condition : memberId < 0");
            memberName = reader.ReadUTF();
            

}


}


}