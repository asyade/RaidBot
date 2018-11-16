


















// Generated on 06/26/2015 11:42:01
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GameRolePlayTaxCollectorInformations : GameRolePlayActorInformations
{

public const short Id = 148;
public override short TypeId
{
    get { return Id; }
}

public Types.TaxCollectorStaticInformations identification;
        public byte guildLevel;
        public int taxCollectorAttack;
        

public GameRolePlayTaxCollectorInformations()
{
}

public GameRolePlayTaxCollectorInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, Types.TaxCollectorStaticInformations identification, byte guildLevel, int taxCollectorAttack)
         : base(contextualId, look, disposition)
        {
            this.identification = identification;
            this.guildLevel = guildLevel;
            this.taxCollectorAttack = taxCollectorAttack;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(identification.TypeId);
            identification.Serialize(writer);
            writer.WriteByte(guildLevel);
            writer.WriteInt(taxCollectorAttack);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            identification = Types.ProtocolTypeManager.GetInstance<Types.TaxCollectorStaticInformations>(reader.ReadShort());
            identification.Deserialize(reader);
            guildLevel = reader.ReadByte();
            if (guildLevel < 0 || guildLevel > 255)
                throw new Exception("Forbidden value on guildLevel = " + guildLevel + ", it doesn't respect the following condition : guildLevel < 0 || guildLevel > 255");
            taxCollectorAttack = reader.ReadInt();
            

}


}


}