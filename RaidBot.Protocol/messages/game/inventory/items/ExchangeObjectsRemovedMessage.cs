


















// Generated on 06/26/2015 11:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeObjectsRemovedMessage : ExchangeObjectMessage
{

public const uint Id = 6532;
public override uint MessageId
{
    get { return Id; }
}

public uint[] objectUID;
        

public ExchangeObjectsRemovedMessage()
{
}

public ExchangeObjectsRemovedMessage(bool remote, uint[] objectUID)
         : base(remote)
        {
            this.objectUID = objectUID;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)objectUID.Length);
            foreach (var entry in objectUID)
            {
                 writer.WriteVaruhint(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            objectUID = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectUID[i] = reader.ReadVaruhint();
            }
            

}


}


}