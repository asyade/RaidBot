


















// Generated on 06/26/2015 11:41:22
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class DocumentReadingBeginMessage : NetworkMessage
{

public const uint Id = 5675;
public override uint MessageId
{
    get { return Id; }
}

public ushort documentId;
        

public DocumentReadingBeginMessage()
{
}

public DocumentReadingBeginMessage(ushort documentId)
        {
            this.documentId = documentId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(documentId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

documentId = reader.ReadVaruhshort();
            if (documentId < 0)
                throw new Exception("Forbidden value on documentId = " + documentId + ", it doesn't respect the following condition : documentId < 0");
            

}


}


}