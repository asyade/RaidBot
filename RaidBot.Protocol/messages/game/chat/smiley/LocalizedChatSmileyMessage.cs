


















// Generated on 06/26/2015 11:41:12
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class LocalizedChatSmileyMessage : ChatSmileyMessage
{

public const uint Id = 6185;
public override uint MessageId
{
    get { return Id; }
}

public ushort cellId;
        

public LocalizedChatSmileyMessage()
{
}

public LocalizedChatSmileyMessage(int entityId, sbyte smileyId, int accountId, ushort cellId)
         : base(entityId, smileyId, accountId)
        {
            this.cellId = cellId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(cellId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            cellId = reader.ReadVaruhshort();
            if (cellId < 0 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
            

}


}


}