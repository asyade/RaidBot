


















// Generated on 06/26/2015 11:42:05
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GameRolePlayPrismInformations : GameRolePlayActorInformations
{

public const short Id = 161;
public override short TypeId
{
    get { return Id; }
}

public Types.PrismInformation prism;
        

public GameRolePlayPrismInformations()
{
}

public GameRolePlayPrismInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, Types.PrismInformation prism)
         : base(contextualId, look, disposition)
        {
            this.prism = prism;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(prism.TypeId);
            prism.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            prism = Types.ProtocolTypeManager.GetInstance<Types.PrismInformation>(reader.ReadShort());
            prism.Deserialize(reader);
            

}


}


}