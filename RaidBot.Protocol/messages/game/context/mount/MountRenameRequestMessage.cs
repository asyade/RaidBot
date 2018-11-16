


















// Generated on 06/26/2015 11:41:19
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MountRenameRequestMessage : NetworkMessage
{

public const uint Id = 5987;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        public int mountId;
        

public MountRenameRequestMessage()
{
}

public MountRenameRequestMessage(string name, int mountId)
        {
            this.name = name;
            this.mountId = mountId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(name);
            writer.WriteVarint(mountId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

name = reader.ReadUTF();
            mountId = reader.ReadVarint();
            

}


}


}