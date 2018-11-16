


















// Generated on 06/26/2015 11:42:05
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class HumanOptionTitle : HumanOption
{

public const short Id = 408;
public override short TypeId
{
    get { return Id; }
}

public ushort titleId;
        public string titleParam;
        

public HumanOptionTitle()
{
}

public HumanOptionTitle(ushort titleId, string titleParam)
        {
            this.titleId = titleId;
            this.titleParam = titleParam;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(titleId);
            writer.WriteUTF(titleParam);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            titleId = reader.ReadVaruhshort();
            if (titleId < 0)
                throw new Exception("Forbidden value on titleId = " + titleId + ", it doesn't respect the following condition : titleId < 0");
            titleParam = reader.ReadUTF();
            

}


}


}