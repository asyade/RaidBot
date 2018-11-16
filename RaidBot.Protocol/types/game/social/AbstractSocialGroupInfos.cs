


















// Generated on 06/26/2015 11:42:11
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class AbstractSocialGroupInfos
{

public const short Id = 416;
public virtual short TypeId
{
    get { return Id; }
}



public AbstractSocialGroupInfos()
{
}



public virtual void Serialize(ICustomDataWriter writer)
{



}

public virtual void Deserialize(ICustomDataReader reader)
{



}


}


}