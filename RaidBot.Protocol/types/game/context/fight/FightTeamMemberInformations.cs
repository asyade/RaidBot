


















// Generated on 06/26/2015 11:42:02
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class FightTeamMemberInformations
{

public const short Id = 44;
public virtual short TypeId
{
    get { return Id; }
}

public int id;
        

public FightTeamMemberInformations()
{
}

public FightTeamMemberInformations(int id)
        {
            this.id = id;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(id);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

id = reader.ReadInt();
            

}


}


}