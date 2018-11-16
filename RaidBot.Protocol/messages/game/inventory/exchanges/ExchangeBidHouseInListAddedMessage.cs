


















// Generated on 06/26/2015 11:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeBidHouseInListAddedMessage : NetworkMessage
{

public const uint Id = 5949;
public override uint MessageId
{
    get { return Id; }
}

public int itemUID;
        public int objGenericId;
        public Types.ObjectEffect[] effects;
        public uint[] prices;
        

public ExchangeBidHouseInListAddedMessage()
{
}

public ExchangeBidHouseInListAddedMessage(int itemUID, int objGenericId, Types.ObjectEffect[] effects, uint[] prices)
        {
            this.itemUID = itemUID;
            this.objGenericId = objGenericId;
            this.effects = effects;
            this.prices = prices;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(itemUID);
            writer.WriteInt(objGenericId);
            writer.WriteUShort((ushort)effects.Length);
            foreach (var entry in effects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)prices.Length);
            foreach (var entry in prices)
            {
                 writer.WriteVaruhint(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

itemUID = reader.ReadInt();
            objGenericId = reader.ReadInt();
            var limit = reader.ReadUShort();
            effects = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 effects[i] = Types.ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadShort());
                 effects[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            prices = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 prices[i] = reader.ReadVaruhint();
            }
            

}


}


}