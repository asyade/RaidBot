


















// Generated on 06/26/2015 11:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeObjectRemovedFromBagMessage : ExchangeObjectMessage
{

public const uint Id = 6010;
public override uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        

public ExchangeObjectRemovedFromBagMessage()
{
}

public ExchangeObjectRemovedFromBagMessage(bool remote, uint objectUID)
         : base(remote)
        {
            this.objectUID = objectUID;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(objectUID);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            objectUID = reader.ReadVaruhint();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            

}


}


}