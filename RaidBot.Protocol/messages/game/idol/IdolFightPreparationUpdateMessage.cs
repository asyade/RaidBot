


















// Generated on 06/26/2015 11:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class IdolFightPreparationUpdateMessage : NetworkMessage
{

public const uint Id = 6586;
public override uint MessageId
{
    get { return Id; }
}

public sbyte idolSource;
        public Types.Idol[] idols;
        

public IdolFightPreparationUpdateMessage()
{
}

public IdolFightPreparationUpdateMessage(sbyte idolSource, Types.Idol[] idols)
        {
            this.idolSource = idolSource;
            this.idols = idols;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(idolSource);
            writer.WriteUShort((ushort)idols.Length);
            foreach (var entry in idols)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

idolSource = reader.ReadSByte();
            if (idolSource < 0)
                throw new Exception("Forbidden value on idolSource = " + idolSource + ", it doesn't respect the following condition : idolSource < 0");
            var limit = reader.ReadUShort();
            idols = new Types.Idol[limit];
            for (int i = 0; i < limit; i++)
            {
                 idols[i] = Types.ProtocolTypeManager.GetInstance<Types.Idol>(reader.ReadShort());
                 idols[i].Deserialize(reader);
            }
            

}


}


}