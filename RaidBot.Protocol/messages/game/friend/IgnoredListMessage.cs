


















// Generated on 06/26/2015 11:41:37
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class IgnoredListMessage : NetworkMessage
{

public const uint Id = 5674;
public override uint MessageId
{
    get { return Id; }
}

public Types.IgnoredInformations[] ignoredList;
        

public IgnoredListMessage()
{
}

public IgnoredListMessage(Types.IgnoredInformations[] ignoredList)
        {
            this.ignoredList = ignoredList;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)ignoredList.Length);
            foreach (var entry in ignoredList)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            ignoredList = new Types.IgnoredInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 ignoredList[i] = Types.ProtocolTypeManager.GetInstance<Types.IgnoredInformations>(reader.ReadShort());
                 ignoredList[i].Deserialize(reader);
            }
            

}


}


}