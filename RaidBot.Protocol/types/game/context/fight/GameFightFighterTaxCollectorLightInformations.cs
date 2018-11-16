


















// Generated on 06/26/2015 11:42:03
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GameFightFighterTaxCollectorLightInformations : GameFightFighterLightInformations
{

public const short Id = 457;
public override short TypeId
{
    get { return Id; }
}

public ushort firstNameId;
        public ushort lastNameId;
        

public GameFightFighterTaxCollectorLightInformations()
{
}

public GameFightFighterTaxCollectorLightInformations(bool sex, bool alive, int id, sbyte wave, ushort level, sbyte breed, ushort firstNameId, ushort lastNameId)
         : base(sex, alive, id, wave, level, breed)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(firstNameId);
            writer.WriteVaruhshort(lastNameId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            firstNameId = reader.ReadVaruhshort();
            if (firstNameId < 0)
                throw new Exception("Forbidden value on firstNameId = " + firstNameId + ", it doesn't respect the following condition : firstNameId < 0");
            lastNameId = reader.ReadVaruhshort();
            if (lastNameId < 0)
                throw new Exception("Forbidden value on lastNameId = " + lastNameId + ", it doesn't respect the following condition : lastNameId < 0");
            

}


}


}