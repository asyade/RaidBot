


















// Generated on 06/26/2015 11:41:45
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeHandleMountsStableMessage : NetworkMessage
{

public const uint Id = 6562;
public override uint MessageId
{
    get { return Id; }
}

public sbyte actionType;
        public uint[] ridesId;
        

public ExchangeHandleMountsStableMessage()
{
}

public ExchangeHandleMountsStableMessage(sbyte actionType, uint[] ridesId)
        {
            this.actionType = actionType;
            this.ridesId = ridesId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(actionType);
            writer.WriteUShort((ushort)ridesId.Length);
            foreach (var entry in ridesId)
            {
                 writer.WriteVaruhint(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

actionType = reader.ReadSByte();
            var limit = reader.ReadUShort();
            ridesId = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 ridesId[i] = reader.ReadVaruhint();
            }
            

}


}


}