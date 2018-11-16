


















// Generated on 06/26/2015 11:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class SymbioticObjectAssociatedMessage : NetworkMessage
{

public const uint Id = 6527;
public override uint MessageId
{
    get { return Id; }
}

public uint hostUID;
        

public SymbioticObjectAssociatedMessage()
{
}

public SymbioticObjectAssociatedMessage(uint hostUID)
        {
            this.hostUID = hostUID;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(hostUID);
            

}

public override void Deserialize(ICustomDataReader reader)
{

hostUID = reader.ReadVaruhint();
            if (hostUID < 0)
                throw new Exception("Forbidden value on hostUID = " + hostUID + ", it doesn't respect the following condition : hostUID < 0");
            

}


}


}