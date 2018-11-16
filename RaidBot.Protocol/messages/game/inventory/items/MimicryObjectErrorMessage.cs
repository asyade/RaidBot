


















// Generated on 06/26/2015 11:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MimicryObjectErrorMessage : SymbioticObjectErrorMessage
{

public const uint Id = 6461;
public override uint MessageId
{
    get { return Id; }
}

public bool preview;
        

public MimicryObjectErrorMessage()
{
}

public MimicryObjectErrorMessage(sbyte reason, sbyte errorCode, bool preview)
         : base(reason, errorCode)
        {
            this.preview = preview;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(preview);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            preview = reader.ReadBoolean();
            

}


}


}