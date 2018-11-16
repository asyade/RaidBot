


















// Generated on 06/26/2015 11:42:05
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class HumanOption
{

public const short Id = 406;
public virtual short TypeId
{
    get { return Id; }
}



public HumanOption()
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