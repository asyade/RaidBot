


















// Generated on 06/26/2015 11:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class SymbioticObjectErrorMessage : ObjectErrorMessage
{

public const uint Id = 6526;
public override uint MessageId
{
    get { return Id; }
}

public sbyte errorCode;
        

public SymbioticObjectErrorMessage()
{
}

public SymbioticObjectErrorMessage(sbyte reason, sbyte errorCode)
         : base(reason)
        {
            this.errorCode = errorCode;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(errorCode);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            errorCode = reader.ReadSByte();
            

}


}


}