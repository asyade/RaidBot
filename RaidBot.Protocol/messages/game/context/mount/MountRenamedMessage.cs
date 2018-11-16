


















// Generated on 06/26/2015 11:41:19
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MountRenamedMessage : NetworkMessage
{

public const uint Id = 5983;
public override uint MessageId
{
    get { return Id; }
}

public int mountId;
        public string name;
        

public MountRenamedMessage()
{
}

public MountRenamedMessage(int mountId, string name)
        {
            this.mountId = mountId;
            this.name = name;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVarint(mountId);
            writer.WriteUTF(name);
            

}

public override void Deserialize(ICustomDataReader reader)
{

mountId = reader.ReadVarint();
            name = reader.ReadUTF();
            

}


}


}