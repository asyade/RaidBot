


















// Generated on 06/26/2015 11:42:05
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GameRolePlayPortalInformations : GameRolePlayActorInformations
{

public const short Id = 467;
public override short TypeId
{
    get { return Id; }
}

public Types.PortalInformation portal;
        

public GameRolePlayPortalInformations()
{
}

public GameRolePlayPortalInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, Types.PortalInformation portal)
         : base(contextualId, look, disposition)
        {
            this.portal = portal;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(portal.TypeId);
            portal.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            portal = Types.ProtocolTypeManager.GetInstance<Types.PortalInformation>(reader.ReadShort());
            portal.Deserialize(reader);
            

}


}


}