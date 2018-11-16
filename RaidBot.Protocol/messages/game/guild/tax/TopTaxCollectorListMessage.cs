


















// Generated on 06/26/2015 11:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TopTaxCollectorListMessage : AbstractTaxCollectorListMessage
{

public const uint Id = 6565;
public override uint MessageId
{
    get { return Id; }
}

public bool isDungeon;
        

public TopTaxCollectorListMessage()
{
}

public TopTaxCollectorListMessage(Types.TaxCollectorInformations[] informations, bool isDungeon)
         : base(informations)
        {
            this.isDungeon = isDungeon;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(isDungeon);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            isDungeon = reader.ReadBoolean();
            

}


}


}