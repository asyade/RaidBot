


















// Generated on 06/26/2015 11:41:19
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MountEmoteIconUsedOkMessage : NetworkMessage
{

public const uint Id = 5978;
public override uint MessageId
{
    get { return Id; }
}

public int mountId;
        public sbyte reactionType;
        

public MountEmoteIconUsedOkMessage()
{
}

public MountEmoteIconUsedOkMessage(int mountId, sbyte reactionType)
        {
            this.mountId = mountId;
            this.reactionType = reactionType;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVarint(mountId);
            writer.WriteSByte(reactionType);
            

}

public override void Deserialize(ICustomDataReader reader)
{

mountId = reader.ReadVarint();
            reactionType = reader.ReadSByte();
            if (reactionType < 0)
                throw new Exception("Forbidden value on reactionType = " + reactionType + ", it doesn't respect the following condition : reactionType < 0");
            

}


}


}