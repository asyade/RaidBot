


















// Generated on 06/26/2015 11:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeObjectsAddedMessage : ExchangeObjectMessage
{

public const uint Id = 6535;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem[] @object;
        

public ExchangeObjectsAddedMessage()
{
}

public ExchangeObjectsAddedMessage(bool remote, Types.ObjectItem[] @object)
         : base(remote)
        {
            this.@object = @object;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)@object.Length);
            foreach (var entry in @object)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            @object = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 @object[i] = new Types.ObjectItem();
                 @object[i].Deserialize(reader);
            }
            

}


}


}