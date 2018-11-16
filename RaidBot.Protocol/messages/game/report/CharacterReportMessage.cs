


















// Generated on 06/26/2015 11:41:55
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class CharacterReportMessage : NetworkMessage
{

public const uint Id = 6079;
public override uint MessageId
{
    get { return Id; }
}

public uint reportedId;
        public sbyte reason;
        

public CharacterReportMessage()
{
}

public CharacterReportMessage(uint reportedId, sbyte reason)
        {
            this.reportedId = reportedId;
            this.reason = reason;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(reportedId);
            writer.WriteSByte(reason);
            

}

public override void Deserialize(ICustomDataReader reader)
{

reportedId = reader.ReadVaruhint();
            if (reportedId < 0)
                throw new Exception("Forbidden value on reportedId = " + reportedId + ", it doesn't respect the following condition : reportedId < 0");
            reason = reader.ReadSByte();
            if (reason < 0)
                throw new Exception("Forbidden value on reason = " + reason + ", it doesn't respect the following condition : reason < 0");
            

}


}


}