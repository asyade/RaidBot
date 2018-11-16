


















// Generated on 06/26/2015 11:42:01
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class PlayerStatus
{

public const short Id = 415;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte statusId;
        

public PlayerStatus()
{
}

public PlayerStatus(sbyte statusId)
        {
            this.statusId = statusId;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(statusId);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

statusId = reader.ReadSByte();
            if (statusId < 0)
                throw new Exception("Forbidden value on statusId = " + statusId + ", it doesn't respect the following condition : statusId < 0");
            

}


}


}