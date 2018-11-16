


















// Generated on 06/26/2015 11:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class HouseGuildShareRequestMessage : NetworkMessage
{

public const uint Id = 5704;
public override uint MessageId
{
    get { return Id; }
}

public bool enable;
        public uint rights;
        

public HouseGuildShareRequestMessage()
{
}

public HouseGuildShareRequestMessage(bool enable, uint rights)
        {
            this.enable = enable;
            this.rights = rights;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(enable);
            writer.WriteVaruhint(rights);
            

}

public override void Deserialize(ICustomDataReader reader)
{

enable = reader.ReadBoolean();
            rights = reader.ReadVaruhint();
            if (rights < 0)
                throw new Exception("Forbidden value on rights = " + rights + ", it doesn't respect the following condition : rights < 0");
            

}


}


}