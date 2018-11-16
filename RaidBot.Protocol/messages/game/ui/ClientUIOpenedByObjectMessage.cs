


















// Generated on 06/26/2015 11:41:57
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ClientUIOpenedByObjectMessage : ClientUIOpenedMessage
{

public const uint Id = 6463;
public override uint MessageId
{
    get { return Id; }
}

public uint uid;
        

public ClientUIOpenedByObjectMessage()
{
}

public ClientUIOpenedByObjectMessage(sbyte type, uint uid)
         : base(type)
        {
            this.uid = uid;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(uid);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            uid = reader.ReadVaruhint();
            if (uid < 0)
                throw new Exception("Forbidden value on uid = " + uid + ", it doesn't respect the following condition : uid < 0");
            

}


}


}