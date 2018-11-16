


















// Generated on 06/26/2015 11:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TaxCollectorListMessage : AbstractTaxCollectorListMessage
{

public const uint Id = 5930;
public override uint MessageId
{
    get { return Id; }
}

public sbyte nbcollectorMax;
        public Types.TaxCollectorFightersInformation[] fightersInformations;
        

public TaxCollectorListMessage()
{
}

public TaxCollectorListMessage(Types.TaxCollectorInformations[] informations, sbyte nbcollectorMax, Types.TaxCollectorFightersInformation[] fightersInformations)
         : base(informations)
        {
            this.nbcollectorMax = nbcollectorMax;
            this.fightersInformations = fightersInformations;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(nbcollectorMax);
            writer.WriteUShort((ushort)fightersInformations.Length);
            foreach (var entry in fightersInformations)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            nbcollectorMax = reader.ReadSByte();
            if (nbcollectorMax < 0)
                throw new Exception("Forbidden value on nbcollectorMax = " + nbcollectorMax + ", it doesn't respect the following condition : nbcollectorMax < 0");
            var limit = reader.ReadUShort();
            fightersInformations = new Types.TaxCollectorFightersInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 fightersInformations[i] = new Types.TaxCollectorFightersInformation();
                 fightersInformations[i].Deserialize(reader);
            }
            

}


}


}