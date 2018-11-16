


















// Generated on 06/26/2015 11:41:24
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class HouseToSellListMessage : NetworkMessage
{

public const uint Id = 6140;
public override uint MessageId
{
    get { return Id; }
}

public ushort pageIndex;
        public ushort totalPage;
        public Types.HouseInformationsForSell[] houseList;
        

public HouseToSellListMessage()
{
}

public HouseToSellListMessage(ushort pageIndex, ushort totalPage, Types.HouseInformationsForSell[] houseList)
        {
            this.pageIndex = pageIndex;
            this.totalPage = totalPage;
            this.houseList = houseList;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(pageIndex);
            writer.WriteVaruhshort(totalPage);
            writer.WriteUShort((ushort)houseList.Length);
            foreach (var entry in houseList)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

pageIndex = reader.ReadVaruhshort();
            if (pageIndex < 0)
                throw new Exception("Forbidden value on pageIndex = " + pageIndex + ", it doesn't respect the following condition : pageIndex < 0");
            totalPage = reader.ReadVaruhshort();
            if (totalPage < 0)
                throw new Exception("Forbidden value on totalPage = " + totalPage + ", it doesn't respect the following condition : totalPage < 0");
            var limit = reader.ReadUShort();
            houseList = new Types.HouseInformationsForSell[limit];
            for (int i = 0; i < limit; i++)
            {
                 houseList[i] = new Types.HouseInformationsForSell();
                 houseList[i].Deserialize(reader);
            }
            

}


}


}