


















// Generated on 06/26/2015 11:41:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class BasicAckMessage : NetworkMessage
{

public const uint Id = 6362;
public override uint MessageId
{
    get { return Id; }
}

public uint seq;
        public ushort lastPacketId;
        

public BasicAckMessage()
{
}

public BasicAckMessage(uint seq, ushort lastPacketId)
        {
            this.seq = seq;
            this.lastPacketId = lastPacketId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(seq);
            writer.WriteVaruhshort(lastPacketId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

seq = reader.ReadVaruhint();
            if (seq < 0)
                throw new Exception("Forbidden value on seq = " + seq + ", it doesn't respect the following condition : seq < 0");
            lastPacketId = reader.ReadVaruhshort();
            if (lastPacketId < 0)
                throw new Exception("Forbidden value on lastPacketId = " + lastPacketId + ", it doesn't respect the following condition : lastPacketId < 0");
            

}


}


}