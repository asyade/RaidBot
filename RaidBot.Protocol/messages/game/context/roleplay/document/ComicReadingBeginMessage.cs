


















// Generated on 06/26/2015 11:41:22
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ComicReadingBeginMessage : NetworkMessage
{

public const uint Id = 6536;
public override uint MessageId
{
    get { return Id; }
}

public ushort comicId;
        

public ComicReadingBeginMessage()
{
}

public ComicReadingBeginMessage(ushort comicId)
        {
            this.comicId = comicId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(comicId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

comicId = reader.ReadVaruhshort();
            if (comicId < 0)
                throw new Exception("Forbidden value on comicId = " + comicId + ", it doesn't respect the following condition : comicId < 0");
            

}


}


}