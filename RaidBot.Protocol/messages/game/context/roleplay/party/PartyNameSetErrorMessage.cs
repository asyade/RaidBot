


















// Generated on 06/26/2015 11:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyNameSetErrorMessage : AbstractPartyMessage
{

public const uint Id = 6501;
public override uint MessageId
{
    get { return Id; }
}

public sbyte result;
        

public PartyNameSetErrorMessage()
{
}

public PartyNameSetErrorMessage(uint partyId, sbyte result)
         : base(partyId)
        {
            this.result = result;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(result);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            result = reader.ReadSByte();
            if (result < 0)
                throw new Exception("Forbidden value on result = " + result + ", it doesn't respect the following condition : result < 0");
            

}


}


}