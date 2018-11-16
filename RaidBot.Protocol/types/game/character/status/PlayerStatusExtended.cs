


















// Generated on 06/26/2015 11:42:01
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class PlayerStatusExtended : PlayerStatus
{

public const short Id = 414;
public override short TypeId
{
    get { return Id; }
}

public string message;
        

public PlayerStatusExtended()
{
}

public PlayerStatusExtended(sbyte statusId, string message)
         : base(statusId)
        {
            this.message = message;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(message);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            message = reader.ReadUTF();
            

}


}


}