


















// Generated on 06/26/2015 11:41:13
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameContextRefreshEntityLookMessage : NetworkMessage
{

public const uint Id = 5637;
public override uint MessageId
{
    get { return Id; }
}

public int id;
        public Types.EntityLook look;
        

public GameContextRefreshEntityLookMessage()
{
}

public GameContextRefreshEntityLookMessage(int id, Types.EntityLook look)
        {
            this.id = id;
            this.look = look;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(id);
            look.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

id = reader.ReadInt();
            look = new Types.EntityLook();
            look.Deserialize(reader);
            

}


}


}