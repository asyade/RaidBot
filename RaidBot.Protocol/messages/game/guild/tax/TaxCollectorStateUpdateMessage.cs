


















// Generated on 06/26/2015 11:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TaxCollectorStateUpdateMessage : NetworkMessage
{

public const uint Id = 6455;
public override uint MessageId
{
    get { return Id; }
}

public int uniqueId;
        public sbyte state;
        

public TaxCollectorStateUpdateMessage()
{
}

public TaxCollectorStateUpdateMessage(int uniqueId, sbyte state)
        {
            this.uniqueId = uniqueId;
            this.state = state;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(uniqueId);
            writer.WriteSByte(state);
            

}

public override void Deserialize(ICustomDataReader reader)
{

uniqueId = reader.ReadInt();
            state = reader.ReadSByte();
            

}


}


}