


















// Generated on 06/26/2015 11:42:04
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GameFightTaxCollectorInformations : GameFightAIInformations
{

public const short Id = 48;
public override short TypeId
{
    get { return Id; }
}

public ushort firstNameId;
        public ushort lastNameId;
        public byte level;
        

public GameFightTaxCollectorInformations()
{
}

public GameFightTaxCollectorInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, sbyte teamId, sbyte wave, bool alive, Types.GameFightMinimalStats stats, ushort[] previousPositions, ushort firstNameId, ushort lastNameId, byte level)
         : base(contextualId, look, disposition, teamId, wave, alive, stats, previousPositions)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
            this.level = level;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(firstNameId);
            writer.WriteVaruhshort(lastNameId);
            writer.WriteByte(level);
            

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
            level = reader.ReadByte();
            if (level < 0 || level > 255)
                throw new Exception("Forbidden value on level = " + level + ", it doesn't respect the following condition : level < 0 || level > 255");
            

}


}


}