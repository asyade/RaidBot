


















// Generated on 06/26/2015 11:41:13
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameContextRemoveElementWithEventMessage : GameContextRemoveElementMessage
{

public const uint Id = 6412;
public override uint MessageId
{
    get { return Id; }
}

public sbyte elementEventId;
        

public GameContextRemoveElementWithEventMessage()
{
}

public GameContextRemoveElementWithEventMessage(int id, sbyte elementEventId)
         : base(id)
        {
            this.elementEventId = elementEventId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(elementEventId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            elementEventId = reader.ReadSByte();
            if (elementEventId < 0)
                throw new Exception("Forbidden value on elementEventId = " + elementEventId + ", it doesn't respect the following condition : elementEventId < 0");
            

}


}


}