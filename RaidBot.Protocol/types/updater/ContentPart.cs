


















// Generated on 06/26/2015 11:42:11
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class ContentPart
{

public const short Id = 350;
public virtual short TypeId
{
    get { return Id; }
}

public string id;
        public sbyte state;
        

public ContentPart()
{
}

public ContentPart(string id, sbyte state)
        {
            this.id = id;
            this.state = state;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(id);
            writer.WriteSByte(state);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

id = reader.ReadUTF();
            state = reader.ReadSByte();
            if (state < 0)
                throw new Exception("Forbidden value on state = " + state + ", it doesn't respect the following condition : state < 0");
            

}


}


}