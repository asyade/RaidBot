


















// Generated on 06/26/2015 11:41:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class KrosmasterInventoryMessage : NetworkMessage
{

public const uint Id = 6350;
public override uint MessageId
{
    get { return Id; }
}

public Types.KrosmasterFigure[] figures;
        

public KrosmasterInventoryMessage()
{
}

public KrosmasterInventoryMessage(Types.KrosmasterFigure[] figures)
        {
            this.figures = figures;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)figures.Length);
            foreach (var entry in figures)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            figures = new Types.KrosmasterFigure[limit];
            for (int i = 0; i < limit; i++)
            {
                 figures[i] = new Types.KrosmasterFigure();
                 figures[i].Deserialize(reader);
            }
            

}


}


}