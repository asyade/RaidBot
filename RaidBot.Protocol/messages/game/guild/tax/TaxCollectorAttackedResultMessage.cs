


















// Generated on 06/26/2015 11:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TaxCollectorAttackedResultMessage : NetworkMessage
{

public const uint Id = 5635;
public override uint MessageId
{
    get { return Id; }
}

public bool deadOrAlive;
        public Types.TaxCollectorBasicInformations basicInfos;
        public Types.BasicGuildInformations guild;
        

public TaxCollectorAttackedResultMessage()
{
}

public TaxCollectorAttackedResultMessage(bool deadOrAlive, Types.TaxCollectorBasicInformations basicInfos, Types.BasicGuildInformations guild)
        {
            this.deadOrAlive = deadOrAlive;
            this.basicInfos = basicInfos;
            this.guild = guild;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(deadOrAlive);
            basicInfos.Serialize(writer);
            guild.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

deadOrAlive = reader.ReadBoolean();
            basicInfos = new Types.TaxCollectorBasicInformations();
            basicInfos.Deserialize(reader);
            guild = new Types.BasicGuildInformations();
            guild.Deserialize(reader);
            

}


}


}